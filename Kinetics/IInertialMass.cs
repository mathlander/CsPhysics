using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.Kinetics
{
    /// <summary>
    /// Represents the concept of a mass with the additional notion of motion.
    /// </summary>
    internal interface IInertialMass : IMass
    {
        /// <summary>
        /// The velocity of the body of mass.  When dealing with relativity, this will vary for a given
        /// body with respect to the reference frame.
        /// </summary>
        double Velocity { get; }

        /// <summary>
        /// The momentum of the body of mass, p = m*v.  When dealing with relativity, this will vary for
        /// a given body with respect to the reference frame.
        /// </summary>
        double Momentum { get; }

        //double Acceleration { get; }

        /// <summary>
        /// Evaluates the force necessary to accelerate the mass.
        /// </summary>
        /// <returns></returns>
        //double ForceNecessaryToAccelerate();
    }
}
