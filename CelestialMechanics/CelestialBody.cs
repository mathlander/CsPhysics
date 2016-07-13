using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsMathematics.DifferentialEquations;
using CsMathematics.LinearAlgebra;

namespace CsPhysics.CelestialMechanics
{
    internal abstract class CelestialBody : ICelestialBody
    {
        private readonly double _t_0;
        private readonly double _t_f;
        private readonly IInertialState _initialState;

        public CelestialBody(int id, string name, double mass, double radius, ICelestialSystem parentSystem, double t_0, double t_f, IInertialState initialState)
        {
            Id = id;
            Name = name;
            Mass = mass;
            Radius = radius;
            ParentSystem = parentSystem;

            // initialPositionFinder expects null inputs for initial time and initial position.
            // initialPositionFinder is used to construct a definition for PositionFunction
            _t_0 = t_0;
            _t_f = t_f;
            _initialState = initialState;

            //PositionFunction = new CelestialPositionVectorFunction(t_0, t_f, initialPosition, mass);

            // mov
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Mass { get; private set; }
        public double Momentum { get { return Mass * Velocity; } }
        public double Radius { get; private set; }
        public double Velocity { get; private set; }
        public ICelestialSystem ParentSystem { get; private set; }
        IInertialState InitialState { get { return _initialState; } }
        IInertialState ICelestialBody.InitialState { get { return _initialState; } }

        /// <summary>
        /// Measures the gravitational force exerted on the current ICelestialBody instance.
        /// </summary>
        /// <param name="secondBody">The second participant in the measure of gravitational force.</param>
        /// <param name="t_i">The time at which we are measuring force.</param>
        /// <param name="r_i">The radial distance between the two bodies at time t_i.</param>
        /// <returns>The force vector exerted by the incoming body at time t_i.</returns>
        private IVector GetForceAtTime(ICelestialBody secondBody, double t_i, double r_i)
        {
            var G = InternalConstants.GravitationalConstant;
            var m1 = this.Mass;
            var m2 = secondBody.Mass;
            var forceMagnitude = G * m1 * m2 / (r_i * r_i);
            /*
            var F_x = 0.0;
            var F_y = 0.0;
            var F_z = 0.0;
            */

            //return new Vector(new[] { F_x, F_y, F_z });
            return null;
        }

        public IInertialState GetInertialStateAtTime(double t_i)
        {
            if (t_i == _t_0)
                return InitialState;

            // TO DO:
            // forward call to ICelestialSystem.GetChildPositionAtTime(double t_0)
            //return ParentSystem.get;
            return null;
        }
    }
}
