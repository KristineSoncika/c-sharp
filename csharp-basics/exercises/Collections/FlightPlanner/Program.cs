using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "./flights.txt";
        private static string[] _readText = File.ReadAllLines(Path);
        private static Dictionary<string, List<string>> _directFlights = new Dictionary<string, List<string>>();

        private static void Main(string[] args)
        {
            for(int i = 0; i < _readText.Length; i++)
            {
                string[] flight = _readText[i].Split(" -> ");

                if (!_directFlights.ContainsKey(flight[0]))
                {
                    _directFlights.Add(flight[0], new List<string> { flight[1] });
                }
                else
                {
                    _directFlights[flight[0]].Add(flight[1]);
                }
            }

            Console.WriteLine("Welcome to Flight Planner!");

            while(true)
            {
                Console.WriteLine($"\n{new string('-', 60)}\n");
                Console.WriteLine("To exit the program press 0");
                Console.WriteLine("To display a list of the available destinations press 1");
                Console.WriteLine("To plan your round trip press 2");

                int response = int.Parse(Console.ReadLine());

                switch(response)
                {
                    case 0:
                        return;
                    case 1:
                        DisplayDestinations();
                        break;
                    case 2:
                        PlanTrip();
                        break;
                    default:
                        return;
                }
            }
        }

        static void DisplayDestinations()
        {
            Console.Clear();
            Console.Write($"\nOur destinations are: {String.Join(" | ", _directFlights.Keys)}\n");
        }

        static void PlanTrip()
        {
            Console.Clear();
            var tripPlan = new List<string>();

            for (int i = 0; i < _directFlights.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_directFlights.ElementAt(i).Key}");
            }

            Console.WriteLine($"\nPress 1 - {_directFlights.Count} to select the trip starting point.");
            tripPlan.Add(_directFlights.ElementAt(int.Parse(Console.ReadLine()) - 1).Key);
            var currentCity = tripPlan[0];

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < _directFlights[currentCity].Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {_directFlights[currentCity][i]}");
                }

                if (_directFlights[currentCity].Count == 1)
                {
                    Console.WriteLine($"\nPress {_directFlights[currentCity].Count} to pick your next destination.");
                }
                else
                {
                    Console.WriteLine($"\nPress 1 - {_directFlights[currentCity].Count} to pick your next destination.");
                }

                tripPlan.Add(_directFlights[currentCity][int.Parse(Console.ReadLine()) - 1]);
                currentCity = tripPlan[tripPlan.Count - 1];

                if (tripPlan[0] == currentCity)
                {
                    Console.Clear();
                    Console.WriteLine("\nThanks for choosing Flight Planner!");
                    Console.WriteLine($"Here is your round trip: {string.Join(" -> ", tripPlan)}");
                    break;
                }
            }
        }
    }
}