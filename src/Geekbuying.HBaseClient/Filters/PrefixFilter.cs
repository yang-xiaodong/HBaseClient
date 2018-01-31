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
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Geekbuying.HBaseClient.Internal;

namespace Geekbuying.HBaseClient.Filters
{
    /// <summary>
    /// Pass results that have same row prefix.
    /// </summary>
    public class PrefixFilter : Filter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixFilter" /> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        public PrefixFilter(byte[] prefix)
        {
            prefix.ArgumentNotNull("prefix");

            Prefix = (byte[]) prefix.Clone();
        }

        /// <summary>
        /// Gets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public byte[] Prefix { get; }

        /// <inheritdoc />
        public override string ToEncodedString()
        {
            const string filterPattern = @"{{""type"":""PrefixFilter"",""value"":""{0}""}}";
            return string.Format(CultureInfo.InvariantCulture, filterPattern, Convert.ToBase64String(Prefix));
        }
    }
}