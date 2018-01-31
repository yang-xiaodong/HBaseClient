using System;
using Geekbuying.HBaseClient.Internal;

namespace Geekbuying.HBaseClient.Tests
{
    internal static class FilterTestRecordExtensions
    {
        internal static FilterTestRecord WithAValue(this FilterTestRecord value, string a)
        {
            value.ArgumentNotNull("value");
            return new FilterTestRecord(value.RowKey, value.LineNumber, a, value.B);
        }

        internal static FilterTestRecord WithBValue(this FilterTestRecord value, string b)
        {
            value.ArgumentNotNull("value");
            return new FilterTestRecord(value.RowKey, value.LineNumber, value.A, b);
        }

        internal static FilterTestRecord WithLineNumberValue(this FilterTestRecord value, int lineNumber)
        {
            value.ArgumentNotNull("value");
            return new FilterTestRecord(value.RowKey, lineNumber, value.A, value.B);
        }
    }

    internal class FilterTestRecord : IEquatable<FilterTestRecord>
    {
        internal FilterTestRecord(string rowKey, int lineNumber, string a, string b)
        {
            RowKey = rowKey;
            LineNumber = lineNumber;
            A = a;
            B = b;
        }

        internal string A { get; }

        internal string B { get; }

        internal int LineNumber { get; }

        internal string RowKey { get; }

        public bool Equals(FilterTestRecord other)
        {
            if (ReferenceEquals(null, other)) return false;
            return LineNumber == other.LineNumber && string.Equals(A, other.A) && string.Equals(RowKey, other.RowKey) &&
                   string.Equals(B, other.B);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as FilterTestRecord);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = LineNumber;
                hashCode = (hashCode * 397) ^ (A != null ? A.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RowKey != null ? RowKey.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (B != null ? B.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return string.Format("RowKey: {0}, LineNumber: {1}, A: {2}, B: {3}", RowKey, LineNumber, A, B);
        }

        public static bool operator ==(FilterTestRecord left, FilterTestRecord right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FilterTestRecord left, FilterTestRecord right)
        {
            return !Equals(left, right);
        }
    }
}