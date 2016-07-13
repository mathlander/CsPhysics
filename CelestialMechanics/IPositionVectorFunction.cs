using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    // DMU Notes (3/19/2016):
    // 
    // once this interface is well defined and stable, reconsile an inheritance relationship
    // with IVectorFieldFunction
    // 
    // this interface may belong in CsMathematics.Calculus or CsMathematics.Function... CsMathematics.DifferentialEquations
    internal interface IPositionVectorFunction // : CsMathematics.Functions.IVectorFieldFunction
    {
        double InitialTime { get; }
        double FinalTime { get; }
        IVector InitialPosition { get; }
        IVector FinalPosition { get; }

        IVector GetPositionAtTime(double t_i);
    }
}
