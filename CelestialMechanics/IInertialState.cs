using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    internal interface IInertialState : IReadOnlyInertialState
    {
        // cartesian position
        new IVector CartesianPosition { get; set; }
        new IVector CartesianVelocity { get; set; }
        new IVector CartesianAcceleration { get; set; }
        new IVector CartesianJerk { get; set; }
        new IVector CartesianSnap { get; set; }
        new IVector CartesianCrackle { get; set; }
        new IVector CartesianPop { get; set; }

        // spherical
        new IVector SphericalPosition { get; set; }
        new IVector SphericalVelocity { get; set; }
        new IVector SphericalAcceleration { get; set; }
        new IVector SphericalJerk { get; set; }
        new IVector SphericalSnap { get; set; }
        new IVector SphericalCrackle { get; set; }
        new IVector SphericalPop { get; set; }
    }
}
