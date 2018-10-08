using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            // In the Main method, place the following code
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            // Create another List that contains that last two planet of our solar system.
            List<string> lastPlanetsList = new List<string> () { "Uranus", "Neptune" };
            // Combine the two lists by using AddRange().
            planetList.AddRange (lastPlanetsList);
            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            // Use Add() again to add Pluto to the end of the list.
            planetList.Add ("Pluto");
            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange (0, 4);
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove ("Pluto");

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>> ();
            Dictionary<string, string> viking = new Dictionary<string, string> () { { "Mars", "Viking" }
            };
            Dictionary<string, string> opportunity = new Dictionary<string, string> () { { "Mars", "Opportunity" }
            };
            Dictionary<string, string> curiosity = new Dictionary<string, string> () { { "Mars", "Curiosity" }
            };
            Dictionary<string, string> mariner = new Dictionary<string, string> () { { "Venus", "Mariner" }
            };
            Dictionary<string, string> venera = new Dictionary<string, string> () { { "Venus", "Venera" }
            };

            probes.Add (viking);
            probes.Add (opportunity);
            probes.Add (curiosity);
            probes.Add (mariner);
            probes.Add (venera);

            foreach (string planet in planetList) {
                List<string> matchingProbes = new List<string> ();
                foreach (Dictionary<string, string> probe in probes) {
                    foreach (KeyValuePair<string, string> probeDetail in probe) {
                        if (planet == probeDetail.Key) {
                            matchingProbes.Add ($"{probeDetail.Value}");
                            Console.WriteLine ($"{probeDetail.Key}: {probeDetail.Value}");
                        }
                    }
                }
                if (matchingProbes.Count > 0) {
                    Console.WriteLine ($"{planet}: {String.Join (", ", matchingProbes)}");
                }
            } { }
        }
    }
}