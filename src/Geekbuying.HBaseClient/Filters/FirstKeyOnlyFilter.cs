﻿// Copyright (c) Geekbuying Corporation
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

namespace Geekbuying.HBaseClient.Filters
{
    /// <summary>
    /// A filter that will only return the first KV from each row.
    /// </summary>
    public class FirstKeyOnlyFilter : Filter
    {
        /// <inheritdoc />
        public override string ToEncodedString()
        {
            return @"{""type"":""FirstKeyOnlyFilter""}";
        }
    }
}