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

using System.Globalization;
using Geekbuying.HBaseClient.Internal;

namespace Geekbuying.HBaseClient.Filters
{
    /// <summary>
    /// This filter is used to filter based on the column family.
    /// </summary>
    public class FamilyFilter : CompareFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyFilter" /> class.
        /// </summary>
        /// <param name="familyCompareOp">The family compare op.</param>
        /// <param name="familyComparator">The family comparator.</param>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">familyCompareOp</exception>
        public FamilyFilter(CompareOp familyCompareOp, ByteArrayComparable familyComparator) : base(familyCompareOp,
            familyComparator)
        {
        }

        /// <inheritdoc />
        public override string ToEncodedString()
        {
            const string filterPattern = @"{{""type"":""FamilyFilter"",""op"":""{0}"",""comparator"":{{{1}}}}}";

            return string.Format(CultureInfo.InvariantCulture, filterPattern, CompareOperation.ToCodeName(),
                Comparator.ToEncodedString());
        }
    }
}