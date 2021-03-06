﻿using System.Collections.Generic;
using System.Linq;

namespace CplSharp.Extensions
{
    /// <summary>
    /// This represents the extension entity for the <see cref="IEnumerable{T}"/> instance.
    /// </summary>
    internal static class EnumerableExtensions
    {
        /// <summary>
        /// Checks whether the given items is null or empty.
        /// </summary>
        /// <param name="items">List of items.</param>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <returns>Returns <c>True</c>, if items is null or empty; otherwise returns <c>False</c>.</returns>
        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
        {
            if (items == null)
            {
                return true;
            }

            return !items.Any();
        }
    }
}
