using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsPhysics.Kinetics;

namespace CsPhysics.CelestialMechanics
{
    internal interface ICelestialBody : IMass
    {
        /// <summary>
        /// The node identifier within a parent system.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// The star, planet, moon, comet, or satellite's name.
        /// </summary>
        new string Name { get; }

        /// <summary>
        /// BodyOfMass of the ICelestialBody instance.
        /// </summary>
        //double BodyOfMass { get; }

        /// <summary>
        /// All celestial bodies are part of a larger system.  For example, a planet
        /// may be part of a solar system, galaxy, or universe.
        /// </summary>
        ICelestialSystem ParentSystem { get; }

        /// <summary>
        /// In a two-body system, two stellar objects in a stable orbit, could define
        /// their position in time as a vector function.  This particular function,
        /// is a solution to a differential equation, involving the gravitational mass
        /// of the bodies, their speed, position, and acceleration.  When evaluated,
        /// the solution function yields a position.
        /// </summary>
        //IPositionVectorFunction PositionFunction { get; }

        /// <summary>
        /// Returns the initial state of the ICelestialBody instance.
        /// </summary>
        IInertialState InitialState { get; }

        /// <summary>
        /// Returns a computes state of the celestial body.
        /// </summary>
        /// <param name="t_i">The time at which the body is evaluated.</param>
        /// <returns>The inertial state of the ICelestialBody instance at time t_i.
        /// That is, the body's position, velocity, and higher order derivatives of
        /// position w.r.t. time.</returns>
        IInertialState GetInertialStateAtTime(double t_i);
    }
}
