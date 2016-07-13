using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.CelestialMechanics
{
    internal class CelestialSystem : ICelestialSystem
    {
        private readonly IDictionary<int, ICelestialBody> _children;
        private readonly double _t_0 = 0.0;

        public CelestialSystem(string name, IReadOnlyList<ICelestialBody> bodies)
        {
            IsRoot = true;
            Name = name;
            ParentSystem = null;

            // to do: add Id to ICelestialBody
            //_children = new Dictionary<int, ICelestialBody>(bodies.Select(new {}));
            Mass = _children.Values.Sum(body => body.Mass);

            // KE = \sum_{i=1}^n \frac{ m v^2 }{ 2 }
            //TotalKineticEnergy = _children.Sum(body => body.GetInertialStateAtTime(_t_0).CartesianVelocity.eu);
        }

        public bool IsRoot { get; private set; }
        public string Name { get; private set; }
        public IDictionary<int, ICelestialBody> Bodies { get { return _children; } }
        public double Mass { get; private set; }
        public double TotalKineticEnergy { get; private set; }
        public ICelestialSystem ParentSystem { get; private set; }
        public IPositionVectorFunction PositionFunction { get; private set; }

        public void AssignToParentSystem(ICelestialSystem parent)
        {
            IsRoot = false;
            ParentSystem = parent;
        }


        public IInertialState GetInertialStateAtTime(int childId, double t_i)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ICelestialBody> ICelestialSystem.Bodies
        {
            get { throw new NotImplementedException(); }
        }

        public IInertialState GetBodyStateAtTime(int bodyId, double t_i)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get { throw new NotImplementedException(); }
        }

        public IInertialState InitialState
        {
            get { throw new NotImplementedException(); }
        }

        public IInertialState GetInertialStateAtTime(double t_i)
        {
            throw new NotImplementedException();
        }

        public double Velocity
        {
            get { throw new NotImplementedException(); }
        }

        public double Momentum
        {
            get { throw new NotImplementedException(); }
        }

        public double Radius
        {
            get { throw new NotImplementedException(); }
        }
    }
}
