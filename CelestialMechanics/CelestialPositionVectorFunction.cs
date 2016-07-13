using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    internal class CelestialPositionVectorFunction : IPositionVectorFunction
    {
        public CelestialPositionVectorFunction(double t_0, double t_f, IVector initialPosition, double firstBodyMass, double secondBodyMass)
        {
            InitialTime = t_0;
            FinalTime = t_f;
            InitialPosition = initialPosition;

            FirstBodyMass = firstBodyMass;
            SecondBodyMass = secondBodyMass;
        }

        public double InitialTime
        {
            get;
            private set;
        }

        public double FinalTime
        {
            get;
            private set;
        }

        public IVector InitialPosition
        {
            get;
            private set;
        }

        public IVector FinalPosition
        {
            get;
            private set;
        }

        public double FirstBodyMass
        {
            get;
            private set;
        }

        public double SecondBodyMass
        {
            get;
            private set;
        }

        public IVector GetPositionAtTime(double t_i)
        {
            // solve the differential equation
            // return a function which allows for an input t_i, where t_0 < t_i < t_f

            throw new NotImplementedException();
        }
    }
}
