using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSpeed(2500, 5, 56, 23));
        }

        static string CalculateSpeed(double distanceInMeters, double hours, double minutes, double seconds)
        {
            double secondsToMinutes = 60;
            double minutesToHour = 60;
            double timeInSeconds = (hours * minutesToHour * secondsToMinutes) + (minutes * secondsToMinutes) + seconds;
            double timeInHours = hours + (minutes / minutesToHour) + (seconds / (secondsToMinutes * minutesToHour));

            double meterToKilometer = 1000;
            double mileToMeter = 1609;
            double distanceInKilometers = distanceInMeters / meterToKilometer;
            double distanceInMiles = distanceInMeters / mileToMeter;

            double metersPerSecond = distanceInMeters / timeInSeconds;
            double kilometersPerHour = distanceInKilometers / timeInHours;
            double milesPerHour = distanceInMiles / timeInHours;
            
            return $"Your speed in m/s is {metersPerSecond:F8}\n" +
                   $"Your speed in km/h is {kilometersPerHour:F8}\n" +
                   $"Your speed in miles/h is {milesPerHour:F8} ";
        }
    }
}

