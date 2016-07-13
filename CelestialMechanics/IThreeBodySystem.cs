using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.CelestialMechanics
{
    internal interface IThreeBodySystem
    {
        IThreeBodyMass FirstMass { get; }
        IThreeBodyMass SecondMass { get; }
        IThreeBodyMass ThirdMass { get; }
    }
}
