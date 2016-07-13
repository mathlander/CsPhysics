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

        // cached values
        private bool _useCachedL1 = false;
        private bool _useCachedL2 = false;
        private bool _useCachedL3 = false;
        private bool _useCachedL4 = false;
        private bool _useCachedL5 = false;
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

            // initialize properties of the three-body system
            DistanceBetweenM1M2 = distanceBetweenM1M2;
            TotalMass = _firstMass.Mass + _secondMass.Mass + _thirdMass.Mass;
            var g = InternalConstants.GravitationalConstant;
            var r = _distanceBetweenM1M2;
            var m = TotalMass;
            Period = Math.Sqrt( Math.Pow(r, 3.0) / (g*m) );
            Mu = _secondMass.Mass / TotalMass;
            Omega = 2 * Math.PI / Period;
            FirstMassScaledRadius = _firstMass.Radius / DistanceBetweenM1M2;
            SecondMassScaledRadius = _secondMass.Radius / DistanceBetweenM1M2;

            // initialize the position and velocity states of the two main bodies
            //
            // the third body's state may be initialized prior to passing it into
            // this constructor, or once the system has been constructed but before
            // any trajectory computations are performed
            _firstMass.Position = new Vector(new[] { -Mu, 0.0 });
            _firstMass.Velocity = new Vector(new[] { 0.0, (-Mu*Omega) });
            _secondMass.Position = new Vector(new[] { (1.0-Mu), 0.0 });
            _secondMass.Velocity = new Vector(new[] { 0.0, (1-Mu)*Omega });
        }

        public IThreeBodyMass FirstMass { get { return _firstMass; } }
        public IThreeBodyMass SecondMass { get { return _secondMass; } }
        public IThreeBodyMass ThirdMass { get { return _thirdMass; } }

        public string FirstMassName { get { return _firstMass.Name; } }
        public string SecondMassName { get { return _secondMass.Name; } }

        public double DistanceBetweenM1M2
        {
            get;
            private set;
        }

        public double TotalMass
        {
            get;
            private set;
        }

        public double Period
        {
            get;
            private set;
        }

        public double Mu
        {
            get;
            private set;
        }

        /// <summary>
        /// Angular velocity of the rotating coordinate system.
        /// </summary>
        public double Omega
        {
            get;
            private set;
        }

        public double FirstMassScaledRadius
        {
            get;
            private set;
        }

        public double SecondMassScaledRadius
        {
            get;
            private set;
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
