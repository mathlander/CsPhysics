using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPhysics.CelestialMechanics
{
    internal static class ThreeBodySystemFactory
    {
        // Satellite Constants
        // assume the satellite to weigh 1000 kg
        private const double SatelliteMass = 1000.0;
        // assume the radius of the satellite to be 20 m
        private const double SatelliteRadius = 20.0;

        // Earth Constants
        // the mass of the Earth (5.97219 * 10^24 kg)
        private const double EarthMass = 5.97219e24;
        // the radius of the earth (6.371e6 meters)
        private const double EarthRadius = 6.371e6;

        // Moon Constants
        // the mass of the moon (7.34767309 * 10^22 kg)
        private const double MoonMass = 7.34767309e22;
        // the radius of the moon (1.7374e6 meters)
        private const double MoonRadius = 1.7374e6;

        // Sun Constants
        //private const double SunMass = 0.0;

        public static IThreeBodySystem CreateEarthMoonSystem()
        {
            // measured in meters
            var distanceEarthToMoon = 3.84405e8;
            var firstMass = new ThreeBodyMass("Earth", EarthMass, EarthRadius, distanceEarthToMoon);
            var secondMass = new ThreeBodyMass("Moon", MoonMass, MoonRadius, distanceEarthToMoon);
            var thirdMass = new ThreeBodyMass("Satellite", SatelliteMass, SatelliteRadius, distanceEarthToMoon);

            return new ThreeBodySystem(firstMass, secondMass, thirdMass, distanceEarthToMoon);
        }
    }
}
