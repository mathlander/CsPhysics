using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.CelestialMechanics
{
    /// <summary>
    /// Represents a celestial system.  A planet-moon system, a solar system,
    /// or a hierarachy of systems.
    /// </summary>
    internal interface ICelestialSystem : ICelestialBody
    {
        /// <summary>
        /// Indicates whether or not the system is the root node in a hierarchy.
        /// </summary>
        bool IsRoot { get; }

        /// <summary>
        /// The gravitational system's name.  In the context of PlanetarySystem instance, this would be the name of the system,
        /// e.g. "Jupiter System".  In the context of a star, this would be the name of the star system, e.g. "Proxima Centauri System".
        /// </summary>
        new string Name { get; }

        /// <summary>
        /// The bodies contained in the system.  For a hierarchy of systems, this represents first-descendant
        /// subsystems (e.g. stars in a galaxy, or moons which orbit a planet).
        /// </summary>
        IEnumerable<ICelestialBody> Bodies { get; }

        /// <summary>
        /// The mass of the ICelestialSystem instance.  Note that this overrides the concept of BodyOfMass for an ICelestialBody.
        /// Consider the public class RockyPlanet.  RockyPlanet inherits from both ICelestialBody, as it bears a gravitational
        /// mass whose position we want to track over time.  RockyPlanet also inherits from ICelestialSystem, as it also has
        /// one moon in 4-week orbits in its gravitational field.
        /// 
        /// Note, that RockyPlanet, when viewed as an ICelestialBody, would want to report its single body mass.  However, when
        /// viewed as an ICelestialSystem, it is more appropriate to report the sum of its own mass and the collective sum of
        /// its orbiting bodies.
        /// </summary>
        double Mass { get; }

        /// <summary>
        /// For a two body system, this is the sum
        ///     E = E_1 + E_2,
        /// where
        ///     E_1 = m_1 * v_1^2 + \frac{ \mu }{ m_1 } \cdot U(r)
        ///     E_2 = m_2 * v_2^2 + \frac{ \mu }{ m_2 } \cdot U(r)
        /// and U(r) represents the potential energy.
        /// </summary>
        double TotalKineticEnergy { get; }

        /// <summary>
        /// Returns a computes state of the celestial body.
        /// </summary>
        /// <param name="bodyId">The ID of the child node whose state is being returned.</param>
        /// <param name="t_i">The time at which the body is evaluated.</param>
        /// <returns>The inertial state of the ICelestialBody instance at time t_i.
        /// That is, the body's position, velocity, and higher order derivatives of
        /// position w.r.t. time.</returns>
        IInertialState GetBodyStateAtTime(int bodyId, double t_i);
    }
}
