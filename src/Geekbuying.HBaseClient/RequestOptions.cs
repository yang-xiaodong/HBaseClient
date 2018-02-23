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
using System.Net.Http;
using Geekbuying.HBaseClient.Internal;
using Geekbuying.HBaseClient.LoadBalancing;
using Polly;
using Polly.Retry;

namespace Geekbuying.HBaseClient
{
    public class RequestOptions
    {
        public RetryPolicy RetryPolicy { get; set; }
        public string AlternativeEndpoint { get; set; }
        public bool KeepAlive { get; set; }
        public int TimeoutMillis { get; set; }
        public int SerializationBufferSize { get; set; }
        public int ReceiveBufferSize { get; set; }
        public int Port { get; set; }
        public Dictionary<string, string> AdditionalHeaders { get; set; }
        public string AlternativeHost { get; set; }

        public void Validate()
        {
            RetryPolicy.ArgumentNotNull("RetryPolicy");
            ArgumentGuardExtensions.ArgumentNotNegative(TimeoutMillis, "TimeoutMillis");
            ArgumentGuardExtensions.ArgumentNotNegative(ReceiveBufferSize, "ReceiveBufferSize");
            ArgumentGuardExtensions.ArgumentNotNegative(SerializationBufferSize, "SerializationBufferSize");
            ArgumentGuardExtensions.ArgumentNotNegative(Port, "Port");
        }

        public static RequestOptions GetDefaultOptions()
        {
            return new RequestOptions
            {
                RetryPolicy = Policy.Handle<HttpRequestException>().WaitAndRetryAsync(2, x => TimeSpan.FromSeconds(1)),
                KeepAlive = true,
                TimeoutMillis = 30000,
                ReceiveBufferSize = 1024 * 1024 * 1,
                SerializationBufferSize = 1024 * 1024 * 1,
                AlternativeEndpoint = Constants.RestEndpointBase,
                Port = 443,
                AlternativeHost = null
            };
        }
    }
}