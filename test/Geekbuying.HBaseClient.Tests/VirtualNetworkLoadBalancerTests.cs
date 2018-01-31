// Copyright (c) Geekbuying Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Geekbuying.HBaseClient.LoadBalancing;
using Geekbuying.HBaseClient.Tests.Utilities;
using Xunit;

namespace Geekbuying.HBaseClient.Tests
{
    public class VirtualNetworkLoadBalancerTests : DisposableContextSpecification
    {
        protected override void Context()
        {
        }

        protected class IgnoreBlackListedEndpointsPolicy : IEndpointIgnorePolicy
        {
            private readonly List<string> _blackListedEndpoints;

            public IgnoreBlackListedEndpointsPolicy(List<string> blacklistedEndpoints)
            {
                _blackListedEndpoints = blacklistedEndpoints;
            }

            public IEndpointIgnorePolicy InnerPolicy { get; private set; }

            public void OnEndpointAccessStart(Uri endpointUri)
            {
            }

            public void OnEndpointAccessCompletion(Uri endpointUri, EndpointAccessResult accessResult)
            {
            }

            public bool ShouldIgnoreEndpoint(Uri endpoint)
            {
                if (_blackListedEndpoints == null) return false;

                var blackListedEndpointFound = _blackListedEndpoints.Find(x => x.Equals(endpoint.OriginalString));

                return blackListedEndpointFound != null;
            }

            public void RefreshIgnoredList()
            {
            }
        }

        private List<string> BuildServersList(int n)
        {
            var list = new List<string>();
            for (var i = 0; i < n; i++) list.Add(string.Format("http://{0}{1}:{2}", "workernode", i, 8090));
            return list;
        }

        private bool CompareLists(List<string> a, List<string> b)
        {
            if (a == null && b != null) return false;

            if (a != null && b == null) return false;

            if (a.Count != b.Count) return false;

            foreach (var aElem in a)
                if (b.FirstOrDefault(bElem => bElem.Equals(aElem, StringComparison.OrdinalIgnoreCase)) ==
                    default(string))
                    return false;

            return true;
        }

        private async Task<int> EmitIntAsync(int count)
        {
            return await Task.FromResult(count);
        }

        private async Task NoOpTask()
        {
            await Task.FromResult(0);
        }

        [Fact]
        public void TestConfigInit()
        {
            var balancer = new LoadBalancerRoundRobin();

            Assert.Equal("workernode", LoadBalancerRoundRobin._workerHostNamePrefix);
            Assert.Equal(8090, LoadBalancerRoundRobin._workerRestEndpointPort);
            Assert.Equal(10.0, LoadBalancerRoundRobin._refreshInterval.TotalMilliseconds);
        }

        [Fact]
        public void TestFailedEndpointsExpiry()
        {
            var numServers = 5;

            Uri activeEndpoint;
            var expectedNumFailedEndpoints = 0;
            var expectedNumAvailableEndpoints = numServers;

            var balancer = new LoadBalancerRoundRobin(numServers);

            Assert.Equal(10.0, LoadBalancerRoundRobin._refreshInterval.TotalMilliseconds);

            for (var i = 0; i < numServers; i++)
            {
                activeEndpoint = balancer.GetEndpoint();
                Assert.NotNull(activeEndpoint);
                balancer.RecordFailure(activeEndpoint);

                expectedNumFailedEndpoints++;
                expectedNumAvailableEndpoints--;
            }

            var endpointsInfoList =
                (balancer._endpointIgnorePolicy as IgnoreFailedEndpointsPolicy)._endpoints.Values.ToArray();

            var failedBefore = Array.FindAll(endpointsInfoList,
                x => x.State == IgnoreFailedEndpointsPolicy.EndpointState.Failed);
            var availableBefore = Array.FindAll(endpointsInfoList,
                x => x.State == IgnoreFailedEndpointsPolicy.EndpointState.Available);

            Assert.Equal(failedBefore.Length, numServers);
            Assert.Empty(availableBefore);

            Thread.Sleep(100);

            var endpoint = balancer.GetEndpoint();
            Assert.NotNull(endpoint);
            balancer.RecordSuccess(endpoint);

            endpointsInfoList =
                (balancer._endpointIgnorePolicy as IgnoreFailedEndpointsPolicy)._endpoints.Values.ToArray();

            var failedAfter = Array.FindAll(endpointsInfoList,
                x => x.State == IgnoreFailedEndpointsPolicy.EndpointState.Failed);
            var availableAfter = Array.FindAll(endpointsInfoList,
                x => x.State == IgnoreFailedEndpointsPolicy.EndpointState.Available);

            Assert.Equal(failedAfter.Length, numServers - 1);
            Assert.Single(availableAfter);
        }

        [Fact]
        public void TestLoadBalancerConcurrency()
        {
            var numServers = 20;
            var balancer = new LoadBalancerRoundRobin(numServers);

            var uniqueEndpointsFetched = new ConcurrentDictionary<string, bool>();

            Parallel.For(0, numServers, i =>
            {
                var endpoint = balancer.GetEndpoint();
                Assert.NotNull(endpoint);

                balancer.RecordSuccess(endpoint);

                Assert.False(uniqueEndpointsFetched.ContainsKey(endpoint.OriginalString));
                Assert.True(uniqueEndpointsFetched.TryAdd(endpoint.OriginalString, true));
            });
        }

        [Fact]
        public void TestLoadBalancerConfigInitialization()
        {
            var stringConfigInitial = Guid.NewGuid().ToString();
            var stringConfigDefault = Guid.NewGuid().ToString();
            var stringConfigExpected = "LoadBalancerTestConfigValue";
            var stringConfigValidKey = "LoadBalancerTestConfigString";
            var stringConfigInvalidKey = "LoadBalancerTestConfigStringInvalid";

            var stringReadInvalid = stringConfigInitial;
            stringReadInvalid =
                LoadBalancerRoundRobin.ReadFromConfig(stringConfigInvalidKey, string.Copy, stringConfigDefault);
            Assert.Equal(stringReadInvalid, stringConfigDefault);

            var stringReadValid = stringConfigInitial;
            stringReadValid =
                LoadBalancerRoundRobin.ReadFromConfig(stringConfigValidKey, string.Copy, stringConfigDefault);
            Assert.Equal(stringReadValid, stringConfigExpected);

            var rnd = new Random();

            var intConfigInitial = rnd.Next();
            var intConfigDefault = rnd.Next();
            var intConfigExpected = 10;
            var intConfigValidKey = "LoadBalancerTestConfigInt";
            var intConfigInvalidKey = "LoadBalancerTestConfigIntInvalid";

            var intReadInvalid = intConfigInitial;
            intReadInvalid = LoadBalancerRoundRobin.ReadFromConfig(intConfigInvalidKey, int.Parse, intConfigDefault);
            Assert.Equal(intReadInvalid, intConfigDefault);

            var intReadValid = intConfigInitial;
            intReadValid = LoadBalancerRoundRobin.ReadFromConfig(intConfigValidKey, int.Parse, intConfigDefault);
            Assert.Equal(intReadValid, intConfigExpected);

            var doubleConfigInitial = rnd.NextDouble();
            var doubleConfigDefault = rnd.NextDouble();
            var doubleConfigExpected = 20.0;
            var doubleConfigValidKey = "LoadBalancerTestConfigDouble";
            var doubleConfigInvalidKey = "LoadBalancerTestConfigDoubleInvalid";

            var doubleReadInvalid = doubleConfigInitial;
            doubleReadInvalid =
                LoadBalancerRoundRobin.ReadFromConfig(doubleConfigInvalidKey, double.Parse, doubleConfigDefault);
            Assert.Equal(doubleReadInvalid, doubleConfigDefault);

            var doubleReadValid = doubleConfigInitial;
            doubleReadValid =
                LoadBalancerRoundRobin.ReadFromConfig(doubleConfigValidKey, double.Parse, doubleConfigDefault);
            Assert.Equal(doubleReadValid, doubleConfigExpected);
        }

        [Fact]
        public void TestLoadBalancerDomainInit()
        {
            var numServers = 10;
            var testDomain = "test.fakedomain.com";
            var balancer = new LoadBalancerRoundRobin(numServers, testDomain);

            var endpoints = balancer._allEndpoints.Select(u => u.ToString()).OrderBy(s => s).ToArray();

            for (var i = 0; i < endpoints.Length; i++)
            {
                var expected = string.Format("http://{0}{1}.{2}:{3}/", LoadBalancerRoundRobin._workerHostNamePrefix, i,
                    testDomain, LoadBalancerRoundRobin._workerRestEndpointPort);
                Assert.Equal(expected, endpoints[i]);
            }
        }

        [Fact]
        public void TestLoadBalancerEndpointsInitialization()
        {
            var numServers = 4;

            var balancer = new LoadBalancerRoundRobin(numServers);
            Assert.Equal(balancer.GetNumAvailableEndpoints(), numServers);

            var expectedServersList = BuildServersList(numServers);

            var actualServersList = new List<string>();

            foreach (var endpoint in balancer._allEndpoints) actualServersList.Add(endpoint.OriginalString);

            Assert.True(CompareLists(actualServersList, expectedServersList));
        }

        [Fact]
        public void TestLoadBalancerIgnorePolicy()
        {
            var numServers = 10;
            var numBlackListedServers = 8;
            var balancer = new LoadBalancerRoundRobin(numServers);

            var blackListedServersList = BuildServersList(numBlackListedServers);

            balancer._endpointIgnorePolicy = new IgnoreBlackListedEndpointsPolicy(blackListedServersList);

            for (var i = 0; i < 2 * numServers; i++)
            {
                Uri selectedEndpoint = null;

                selectedEndpoint = balancer.GetEndpoint();
                var selectedEndpointFoundInBlackList =
                    blackListedServersList.Find(x => x.Equals(selectedEndpoint.OriginalString));
                Assert.Null(selectedEndpointFoundInBlackList);

                balancer.RecordSuccess(selectedEndpoint);
            }
        }

        [Fact]
        public void TestLoadBalancerRoundRobin()
        {
            var numServers = 10;

            var balancer = new LoadBalancerRoundRobin(numServers);
            var initRRIdx = balancer._endpointIndex;

            for (var i = 0; i < 2 * numServers; i++)
            {
                Uri selectedEndpoint = null;

                selectedEndpoint = balancer.GetEndpoint();

                var expectedRRIdx = (initRRIdx + i) % numServers;
                var expectedEndpoint = balancer._allEndpoints[expectedRRIdx];
                Assert.Equal(selectedEndpoint.OriginalString, expectedEndpoint.OriginalString);

                balancer.RecordSuccess(selectedEndpoint);
            }
        }
    }
}