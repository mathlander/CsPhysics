using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    internal class InertialState : IInertialState
    {
        public InertialState() : this(new Vector(new[] { 0.0, 0.0, 0.0 }), new Vector(new[] { 0.0, 0.0, 0.0 }), new Vector(new[] { 0.0, 0.0, 0.0 })) {}

        public InertialState(IVector cartesianPosition, IVector cartesianVelocity, IVector cartesianAcceleration)
        {
            CartesianPosition = cartesianPosition;
            CartesianVelocity = cartesianVelocity;
            CartesianAcceleration = cartesianAcceleration;
            CartesianJerk = new Vector(new[] { 0.0, 0.0, 0.0 });
            CartesianSnap = new Vector(new[] { 0.0, 0.0, 0.0 });
            CartesianCrackle = new Vector(new[] { 0.0, 0.0, 0.0 });
            CartesianPop = new Vector(new[] { 0.0, 0.0, 0.0 });

            SphericalPosition = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalVelocity = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalAcceleration = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalJerk = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalSnap = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalCrackle = new Vector(new[] { 0.0, 0.0, 0.0 });
            SphericalPop = new Vector(new[] { 0.0, 0.0, 0.0 });
        }

        // cartesian position
        public IVector CartesianPosition { get; set; }
        public IVector CartesianVelocity { get; set; }
        public IVector CartesianAcceleration { get; set; }
        public IVector CartesianJerk { get; set; }
        public IVector CartesianSnap { get; set; }
        public IVector CartesianCrackle { get; set; }
        public IVector CartesianPop { get; set; }

        // spherical
        public IVector SphericalPosition { get; set; }
        public IVector SphericalVelocity { get; set; }
        public IVector SphericalAcceleration { get; set; }
        public IVector SphericalJerk { get; set; }
        public IVector SphericalSnap { get; set; }
        public IVector SphericalCrackle { get; set; }
        public IVector SphericalPop { get; set; }
    }
}
