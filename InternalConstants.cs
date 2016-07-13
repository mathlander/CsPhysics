using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.AbstractAlgebra.NumberFields;

namespace CsPhysics
{
    internal static class InternalConstants
    {
        /// <summary>
        /// Newton's constant, G = 6.67408(31) x 10^{-11} m^3 kg^{-1} s^{-2}.
        /// </summary>
        internal static readonly double GravitationalConstant = 0.000000000066740831;

        /// <summary>
        /// Newton's constant, G = 6.67408(31) x 10^{-11} m^3 kg^{-1} s^{-2}, expressed as a rational number.
        /// </summary>
        //internal static readonly double GravitationalConstantRational = new RationalElement(0, 66740831, new BigInteger(1e11));
    }
}
