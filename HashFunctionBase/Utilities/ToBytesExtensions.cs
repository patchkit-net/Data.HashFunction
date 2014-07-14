﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Utilities
{
    /// <summary>
    /// Static class to provide ToBytes extension functions.
    /// </summary>
    internal static class ToBytesExtensions
    {
        /// <summary>
        /// Converts an enumerable collection of UInt32 values to an enumerable collection of bytes as if it were a single integer.
        /// </summary>
        /// <param name="values">Array of UInt32 values to convert to a byte array.</param>
        /// <returns>Bytes representing the UInt32 array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<byte> ToBytes(this IEnumerable<UInt32> values)
        {
            return values.SelectMany(v => BitConverter.GetBytes(v));
        }
    }
}