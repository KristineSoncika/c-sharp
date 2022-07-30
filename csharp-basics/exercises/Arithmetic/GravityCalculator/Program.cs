
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main()
        {
            FreeFallDistanceCalculator();
        }

        static void FreeFallDistanceCalculator()
        {
            double earthGravitationalPull = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            double finalPosition = 0.5 * (earthGravitationalPull * Math.Pow(fallingTime, 2)) + (initialVelocity * fallingTime) + initialPosition;
            Console.WriteLine($"The object's position after {fallingTime} seconds is {finalPosition}m.");
        }
    }
}