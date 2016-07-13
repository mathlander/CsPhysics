using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    /// <summary>
    /// A recreation of the previous results.
    /// </summary>
    internal class ThreeBodySystem : IThreeBodySystem
    {
        private readonly double _distanceBetweenM1M2;
        private readonly IThreeBodyMass _firstMass;
        private readonly IThreeBodyMass _secondMass;
        private readonly IThreeBodyMass _thirdMass;

        // this will need to be maintained in the IThreeBodyMass instance for the third body
        private readonly IVector _thirdMassInitialState;

        // cached values
        private bool _useCachedTotalMass = false;
        private bool _useCachedPeriod = false;
        private bool _useCachedMu = false;
        private bool _useCachedOmega = false;
        private bool _useCachedScaledRadius1 = false;
        private bool _useCachedScaledRadius2 = false;
        private bool _useCachedL1 = false;
        private bool _useCachedL2 = false;
        private bool _useCachedL3 = false;
        private bool _useCachedL4 = false;
        private bool _useCachedL5 = false;
        private double _cachedTotalMass = 0.0;
        private double _cachedPeriod = 0.0;
        private double _cachedMu = 0.0;
        private double _cachedOmega = 0.0;
        private double _cachedScaledRadius1 = 0.0;
        private double _cachedScaledRadius2 = 0.0;
        private IVector _cachedL1;
        private IVector _cachedL2;
        private IVector _cachedL3;
        private IVector _cachedL4;
        private IVector _cachedL5;

        public ThreeBodySystem(IThreeBodyMass firstMass, IThreeBodyMass secondMass, IThreeBodyMass thirdMass, double distanceBetweenM1M2)
        {
            _firstMass = firstMass;
            _secondMass = secondMass;
            _thirdMass = thirdMass;
            _distanceBetweenM1M2 = distanceBetweenM1M2;
        }

        public IThreeBodyMass FirstMass { get { return _firstMass; } }
        public IThreeBodyMass SecondMass { get { return _secondMass; } }
        public IThreeBodyMass ThirdMass { get { return _thirdMass; } }

        public double DistanceBetweenM1M2 { get { return _distanceBetweenM1M2; } }

        public string FirstMassName { get { return _firstMass.Name; } }
        public string SecondMassName { get { return _secondMass.Name; } }

        public double TotalMass
        {
            get
            {
                if (!_useCachedTotalMass)
                {
                    _cachedTotalMass = _firstMass.Mass + _secondMass.Mass + _thirdMass.Mass;
                    _useCachedTotalMass = true;
                }

                return _cachedTotalMass;
            }
        }

        public double Period
        {
            get
            {
                if (!_useCachedPeriod)
                {
                    var g = InternalConstants.GravitationalConstant;
                    var r = _distanceBetweenM1M2;
                    var m = TotalMass;
                    _cachedPeriod = Math.Sqrt( Math.Pow(r, 3.0) / (g*m) );
                    _useCachedPeriod = true;
                }

                return _cachedPeriod;
            }
        }

        public double Mu
        {
            get
            {
                if (!_useCachedMu)
                {
                    _cachedMu = _secondMass.Mass / TotalMass;
                    _useCachedMu = true;
                }

                return _cachedMu;
            }
        }

        /// <summary>
        /// Angular velocity of the rotating coordinate system.
        /// </summary>
        public double Omega
        {
            get
            {
                if (!_useCachedOmega)
                {
                    _cachedOmega = 2 * Math.PI / Period;
                    _useCachedOmega = true;
                }

                return _cachedOmega;
            }
        }

        public double FirstMassScaledRadius
        {
            get
            {
                if (!_useCachedScaledRadius1)
                {
                    _cachedScaledRadius1 = _secondMass.Radius / _distanceBetweenM1M2;
                    _useCachedScaledRadius1 = true;
                }

                return _cachedScaledRadius1;
            }
        }

        public double SecondMassScaledRadius
        {
            get
            {
                if (!_useCachedScaledRadius2)
                {
                    _cachedScaledRadius2 = _secondMass.Radius / _distanceBetweenM1M2;
                    _useCachedScaledRadius2 = true;
                }

                return _cachedScaledRadius2;
            }
        }

        private IVector ComputeLagrangePointOne()
        {
            if (_useCachedL1)
                return _cachedL1;

            var mu = Mu;

            // L1 is the solution to the equation:
            //
            // x^5 - (3 - mu)*x^4 + (3 - 2*mu)*x^3 - mu*x^2 + 2*mu*x - mu = 0
            //
            var a = 1;
            var b = -(3 - 2) * mu;
            var c = 3 - 2 * mu;
            var d = -mu;
            var e = 2 * mu;
            var f = -mu;

            //var radialDistance = t
            return null;
        }
    }
}
