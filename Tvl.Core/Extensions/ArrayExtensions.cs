namespace Tvl
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public static partial class ArrayExtensions
    {
        public static IList<T> Subarray<T>(this T[] array, int startIndex)
        {
            ContractSlim.Requires<ArgumentNullException>(array != null, "array");
            ContractSlim.Requires<ArgumentOutOfRangeException>(startIndex >= 0);
            ContractSlim.Requires<ArgumentException>(startIndex <= array.Length);
            Contract.Ensures(Contract.Result<IList<T>>() != null);

            if (startIndex == 0)
                return array;

            return new ArraySegment<T>(array, startIndex, array.Length - startIndex);
        }

        public static IList<T> Subarray<T>(this T[] array, int startIndex, int count)
        {
            ContractSlim.Requires<ArgumentNullException>(array != null, "array");
            ContractSlim.Requires<ArgumentOutOfRangeException>(startIndex >= 0);
            ContractSlim.Requires<ArgumentOutOfRangeException>(count >= 0);
            ContractSlim.Requires<ArgumentException>(startIndex <= array.Length);
            ContractSlim.Requires<ArgumentException>(checked(startIndex + count) <= array.Length);
            Contract.Ensures(Contract.Result<IList<T>>() != null);

            if (startIndex == 0 && count == array.Length)
                return array;

            return new ArraySegment<T>(array, startIndex, count);
        }

        public static T[] CloneArray<T>(this T[] array)
        {
            ContractSlim.Requires<ArgumentNullException>(array != null, "array");
            Contract.Ensures(Contract.Result<T[]>() != null);

            return (T[])array.Clone();
        }
    }
}
