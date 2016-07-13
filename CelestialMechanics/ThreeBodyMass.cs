using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    public class ThreeBodyMassException : Exception { public ThreeBodyMassException(string message) : base(message) { } }

    internal class ThreeBodyMass : IThreeBodyMass
    {
        private readonly double _mass;
        private readonly double _radius;
        private readonly double _scalingFactor;
        private readonly double _scaledRadius;
        private readonly string _name;

        private double _xOrdinal = 0.0;
        private double _yOrdinal = 0.0;

        /// <summary>
        /// Constructs the instance properties of one of three masses in a three-body system.
        /// </summary>
        /// <param name="name">The name of the mass.</param>
        /// <param name="mass">The mass of the gravitional body measured in kilograms (kg).</param>
        /// <param name="radius">The radius of the gravitational body measured in meters (m).</param>
        /// <param name="scalingFactor">The distance between M1 and M2 measured in meters (m).  This value is used to scale the radius of the
        /// celestial bodies (e.g. planet/star).  Note that this is necessary, as in the planar restricted three-body
        /// problem, the distance between M1 and M2 is scaled down to 1.</param>
        public ThreeBodyMass(string name, double mass, double radius, double scalingFactor)
        {
            if (string.IsNullOrEmpty(name))
                throw new ThreeBodyMassException("The name of the ThreeBodyMass must not be null or empty.");

            if (mass <= 0)
                throw new ThreeBodyMassException("The mass of a ThreeBodyMass instance must be greater than 0.");

            if (radius <= 0)
                throw new ThreeBodyMassException("The radius of a ThreeBodyMass instance must be greater than 0.");

            if (scalingFactor <= radius)
                throw new ThreeBodyMassException("The scaling factor for a three-body system must be greater than the radius of any body in the system.  Otherwise, two or more of the bodies may be considered as a single body.");

            _name = name;
            _mass = mass;
            _radius = radius;
            _scalingFactor = scalingFactor;
            _scaledRadius = radius / scalingFactor;

            OrdinalX = 0.0;
            OrdinalY = 0.0;
            Position = new Vector(new[] { 0.0, 0.0 });
            Velocity = new Vector(new[] { 0.0, 0.0 });
        }

        public double Mass
        {
            get { return _mass; }
        }

        public double OrdinalX
        {
            get;
            set;
        }

        public double OrdinalY
        {
            get;
            set;
        }

        public double Radius
        {
            get { return _radius; }
        }

        public double ScaledRadius
        {
            get { return _scaledRadius; }
        }

        public IVector Position
        {
            get;
            set;
        }

        public IVector Velocity
        {
            get;
            set;
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, BodyOfMass: {1} kg, Radius: {2} m", Name, Mass, Radius);
        }
    }
}
