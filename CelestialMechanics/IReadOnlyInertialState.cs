using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    internal interface IReadOnlyInertialState
    {
        // cartesian position
        IVector CartesianPosition { get; }
        IVector CartesianVelocity { get; }
        IVector CartesianAcceleration { get; }
        IVector CartesianJerk { get; }
        IVector CartesianSnap { get; }
        IVector CartesianCrackle { get; }
        IVector CartesianPop { get; }

        // spherical
        IVector SphericalPosition { get; }
        IVector SphericalVelocity { get; }
        IVector SphericalAcceleration { get; }
        IVector SphericalJerk { get; }
        IVector SphericalSnap { get; }
        IVector SphericalCrackle { get; }
        IVector SphericalPop { get; }
    }
}
