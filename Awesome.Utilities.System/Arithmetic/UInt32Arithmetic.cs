﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Arithmetic
{
    /// <summary>
    ///     An arithmetic interface for uint
    /// </summary>
    public struct UInt32Arithmetic : IArithmetic<uint>
    {
        #region IArithmetic<uint> Members
        /// <summary>
        /// Adds the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Add(uint x, uint y)
        {
            return x + y;
        }

        /// <summary>
        /// Substracts the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Substract(uint x, uint y)
        {
            return x - y;
        }

        /// <summary>
        /// Multiplies the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Multiply(uint x, uint y)
        {
            return x * y;
        }

        /// <summary>
        /// Divides the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Divide(uint x, uint y)
        {
            return x / y;
        }

        /// <summary>
        /// Powers the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Power(uint x, uint y)
        {
            return (uint)Math.Pow(x, y);
        }

        /// <summary>
        /// Moduloes the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Modulo(uint x, uint y)
        {
            return x % y;
        }

        /// <summary>
        /// Greaters the than.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool GreaterThan(uint x, uint y)
        {
            return x > y;
        }

        /// <summary>
        /// Greaters the or equal to.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool GreaterOrEqualTo(uint x, uint y)
        {
            return x >= y;
        }

        /// <summary>
        /// Lesses the than.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool LessThan(uint x, uint y)
        {
            return x < y;
        }

        /// <summary>
        /// Lesses the or equal to.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool LessOrEqualTo(uint x, uint y)
        {
            return x <= y;
        }

        /// <summary>
        /// Equalses the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool Equals(uint x, uint y)
        {
            return x == y;
        }

        /// <summary>
        /// Finds the maximum value between two numbers.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Max(uint x, uint y)
        {
            return Math.Max(x, y);
        }

        /// <summary>
        /// Finds the minimum value between two numbers.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public uint Min(uint x, uint y)
        {
            return Math.Min(x, y);
        }

        /// <summary>
        /// Returns the absolute value of the number
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public uint Abs(uint x)
        {
            return x;
        }

        /// <summary>
        /// Gets the zero value.
        /// </summary>
        public uint Zero { get { return 0; } }
        #endregion
    }
}
