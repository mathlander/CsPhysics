using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.Kinetics
{
    /// <summary>
    /// Represents the most general concept of a body of mass.
    /// </summary>
    internal interface IMass
    {
        /// <summary>
        /// The mass of the object.
        /// </summary>
        double Mass { get; }

        /// <summary>
        /// The radius of the body.  For an atom, this will represent the radius of the nucleus, when considering
        /// the components of the atom (nucleus and electrons), or the distance from the nucleus to the outermost
        /// electron, when considering the atom as a point mass.
        /// 
        /// In the case of a celestial body (planet or star), the radius is the distance from the center of the
        /// body to the "desirable distance of passage".  Here, the "desirable distance of passage" is an abstraction
        /// of an event horizon.  Surely, any vessel which travels within the event horizon of a black hole is lost,
        /// so too is any probe which travels inside the atmosphere of a planet, or into the corona of a star.
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// If not set, this property returns the name of the class.
        /// </summary>
        string Name { get; }
    }
}
