using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;
using CsPhysics.Kinetics;

namespace CsPhysics.CelestialMechanics
{
    internal interface IThreeBodyMass : IMass
    {
        double OrdinalX { get; set; }
        double OrdinalY { get; set; }
        double ScaledRadius { get; }
        IVector Position { get; set; }
        IVector Velocity { get; set; }
    }
}
