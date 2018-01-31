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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Geekbuying.HBaseClient.LoadBalancing;
using org.apache.hadoop.hbase.rest.protobuf.generated;
using Polly;
using Xunit;

namespace Geekbuying.HBaseClient.Tests.Clients
{
    public class GatewayClientTest : HBaseClientTestBase
    {
        public override IHBaseClient CreateClient()
        {
            var options = RequestOptions.GetDefaultOptions();
            options.RetryPolicy = Policy.Handle<HttpRequestException>().WaitAndRetry(1, x => TimeSpan.FromSeconds(1));
            options.TimeoutMillis = 30000;
            options.KeepAlive = false;
            return new HBaseClient(ClusterCredentialsFactory.CreateFromFile(@".\credentials.txt"), options);
        }

        [Fact]
        public override void TestFullScan()
        {
            var client = CreateClient();

            StoreTestData(client);

            var scanOptions = RequestOptions.GetDefaultOptions();
            scanOptions.AlternativeEndpoint = Constants.RestEndpointBaseZero;

            // full range scan
            var scanSettings = new Scanner {batch = 10};
            ScannerInformation scannerInfo = null;
            try
            {
                scannerInfo = client.CreateScannerAsync(testTableName, scanSettings, scanOptions).Result;

                CellSet next;
                var expectedSet = new HashSet<int>(Enumerable.Range(0, 100));
                while ((next = client.ScannerGetNextAsync(scannerInfo, scanOptions).Result) != null)
                {
                    Assert.Equal(10, next.rows.Count);
                    foreach (var row in next.rows)
                    {
                        var k = BitConverter.ToInt32(row.key, 0);
                        expectedSet.Remove(k);
                    }
                }

                Assert.Empty(expectedSet);
            }
            finally
            {
                if (scannerInfo != null) client.DeleteScannerAsync(testTableName, scannerInfo, scanOptions).Wait();
            }
        }

        [Fact]
        public void TestScannerCreation()
        {
            var client = CreateClient();
            var scanSettings = new Scanner {batch = 2};

            var scanOptions = RequestOptions.GetDefaultOptions();
            scanOptions.AlternativeEndpoint = Constants.RestEndpointBaseZero;
            ScannerInformation scannerInfo = null;
            try
            {
                scannerInfo = client.CreateScannerAsync(testTableName, scanSettings, scanOptions).Result;
                Assert.Equal(testTableName, scannerInfo.TableName);
                Assert.NotNull(scannerInfo.ScannerId);
                Assert.False(scannerInfo.ScannerId.StartsWith("/"), "scanner id starts with a slash");
                Assert.NotNull(scannerInfo.ResponseHeaderCollection);
            }
            finally
            {
                if (scannerInfo != null) client.DeleteScannerAsync(testTableName, scannerInfo, scanOptions).Wait();
            }
        }

        [Fact]
        public void TestScannerDeletion()
        {
            var client = CreateClient();

            // full range scan
            var scanSettings = new Scanner {batch = 10};
            var scanOptions = RequestOptions.GetDefaultOptions();
            scanOptions.AlternativeEndpoint = Constants.RestEndpointBaseZero;
            ScannerInformation scannerInfo = null;

            try
            {
                scannerInfo = client.CreateScannerAsync(testTableName, scanSettings, scanOptions).Result;
                Assert.Equal(testTableName, scannerInfo.TableName);
                Assert.NotNull(scannerInfo.ScannerId);
                Assert.False(scannerInfo.ScannerId.StartsWith("/"), "scanner id starts with a slash");
                Assert.NotNull(scannerInfo.ResponseHeaderCollection);
                // delete the scanner
                client.DeleteScannerAsync(testTableName, scannerInfo, scanOptions).Wait();
                // try to fetch data use the deleted scanner
                scanOptions.RetryPolicy =
                    Policy.Handle<HttpRequestException>().WaitAndRetry(1, x => TimeSpan.FromSeconds(1));
                client.ScannerGetNextAsync(scannerInfo, scanOptions).Wait();
            }
            finally
            {
                if (scannerInfo != null) client.DeleteScannerAsync(testTableName, scannerInfo, scanOptions).Wait();
            }
        }

        [Fact]
        public override void TestSubsetScan()
        {
            var client = CreateClient();
            const int startRow = 15;
            const int endRow = 15 + 13;
            StoreTestData(client);

            // subset range scan
            var scanSettings = new Scanner
            {
                batch = 10,
                startRow = BitConverter.GetBytes(startRow),
                endRow = BitConverter.GetBytes(endRow)
            };
            var scanOptions = RequestOptions.GetDefaultOptions();
            scanOptions.AlternativeEndpoint = Constants.RestEndpointBaseZero;
            ScannerInformation scannerInfo = null;
            try
            {
                scannerInfo = client.CreateScannerAsync(testTableName, scanSettings, scanOptions).Result;

                CellSet next;
                var expectedSet = new HashSet<int>(Enumerable.Range(startRow, endRow - startRow));
                while ((next = client.ScannerGetNextAsync(scannerInfo, scanOptions).Result) != null)
                    foreach (var row in next.rows)
                    {
                        var k = BitConverter.ToInt32(row.key, 0);
                        expectedSet.Remove(k);
                    }

                Assert.Empty(expectedSet);
            }
            finally
            {
                if (scannerInfo != null) client.DeleteScannerAsync(testTableName, scannerInfo, scanOptions).Wait();
            }
        }
    }
}