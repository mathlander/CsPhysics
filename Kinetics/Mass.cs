using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.Kinetics
{
    internal class BodyOfMass : IMass
    {
        private readonly double _mass;
        private readonly double _radius;
        private readonly string _name;

        public BodyOfMass(string name, double mass, double radius)
        {
            _name = name;
            _mass = mass;
            _radius = radius;
        }

        public double Mass
        {
            get { return _mass; }
        }

        public double Radius
        {
            get { return _radius ; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
