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

namespace Geekbuying.HBaseClient.Tests.Utilities
{
    [Serializable]
    internal sealed class Pair<TFirst, TSecond> : ICloneable, IComparable, IComparable<Pair<TFirst, TSecond>>,
        IEquatable<Pair<TFirst, TSecond>>
    {
        private readonly Comparison<TFirst> _firstComparison;
        private readonly IEqualityComparer<TFirst> _firstEqualityComparer;
        private readonly Comparison<TSecond> _secondComparison;
        private readonly IEqualityComparer<TSecond> _secondEqualityComparer;
        private TFirst _first;
        private TSecond _second;

        internal Pair() : this(default(TFirst), null, Comparer<TFirst>.Default, default(TSecond), null,
            Comparer<TSecond>.Default)
        {
        }

        internal Pair(TFirst first, TSecond second) : this(first, null, Comparer<TFirst>.Default, second, null,
            Comparer<TSecond>.Default)
        {
        }

        internal Pair(
            TFirst first,
            IEqualityComparer<TFirst> firstEqualityComparer,
            IComparer<TFirst> firstSortingComparer,
            TSecond second,
            IEqualityComparer<TSecond> secondEqualityComparer,
            IComparer<TSecond> secondSortingComparer)
        {
            _first = first;
            _firstEqualityComparer = firstEqualityComparer ?? EqualityComparer<TFirst>.Default;
            _firstComparison = (firstSortingComparer ?? Comparer<TFirst>.Default).Compare;
            _second = second;
            _secondEqualityComparer = secondEqualityComparer ?? EqualityComparer<TSecond>.Default;
            _secondComparison = (secondSortingComparer ?? Comparer<TSecond>.Default).Compare;
        }

        internal Pair(
            TFirst first,
            IEqualityComparer<TFirst> firstEqualityComparer,
            Comparison<TFirst> firstSortingComparison,
            TSecond second,
            IEqualityComparer<TSecond> secondEqualityComparer,
            Comparison<TSecond> secondSortingComparison)
        {
            _first = first;
            _firstEqualityComparer = firstEqualityComparer ?? EqualityComparer<TFirst>.Default;
            _firstComparison = firstSortingComparison ?? Comparer<TFirst>.Default.Compare;
            _second = second;
            _secondEqualityComparer = secondEqualityComparer ?? EqualityComparer<TSecond>.Default;
            _secondComparison = secondSortingComparison ?? Comparer<TSecond>.Default.Compare;
        }

        internal TFirst First
        {
            get => _first;
            set => _first = value;
        }

        internal TSecond Second
        {
            get => _second;
            set => _second = value;
        }

        public object Clone()
        {
            var first = _first;
            var cloneable1 = (object) _first as ICloneable;
            if (cloneable1 != null) first = (TFirst) cloneable1.Clone();
            var second = _second;
            var cloneable2 = (object) _second as ICloneable;
            if (cloneable2 != null) second = (TSecond) cloneable2.Clone();
            return new Pair<TFirst, TSecond>(first, _firstEqualityComparer, _firstComparison, second,
                _secondEqualityComparer, _secondComparison);
        }

        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj as Pair<TFirst, TSecond>);
        }

        public int CompareTo(Pair<TFirst, TSecond> other)
        {
            if (other == null) return 1;
            var num = _firstComparison(_first, other.First);
            if (num == 0)
                return _secondComparison(_second, other.Second);
            return num;
        }

        public bool Equals(Pair<TFirst, TSecond> other)
        {
            if (ReferenceEquals(null, other) || !_firstEqualityComparer.Equals(First, other.First))
                return false;
            return _secondEqualityComparer.Equals(Second, other.Second);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pair<TFirst, TSecond>);
        }

        public override int GetHashCode()
        {
            return (_first.GetHashCode() * 397) ^ _second.GetHashCode();
        }

        public static bool operator ==(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            return Equals(left, right);
        }

        public static bool operator >(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            if (ReferenceEquals(null, left))
                return !ReferenceEquals(null, right);
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            if (ReferenceEquals(null, left))
                return !ReferenceEquals(null, right);
            return left.CompareTo(right) >= 0;
        }

        public static bool operator !=(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            if (ReferenceEquals(null, left))
                return !ReferenceEquals(null, right);
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            if (ReferenceEquals(null, left))
                return !ReferenceEquals(null, right);
            return left.CompareTo(right) <= 0;
        }
    }
}