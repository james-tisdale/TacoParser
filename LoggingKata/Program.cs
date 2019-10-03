using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines.Length}");
            if(lines.Length == 1)
            {
                logger.LogWarning("Warning: only read 1 line");
            }

            if(lines.Length == 0)
            {
                logger.LogError("Error: 0 lines read");
            }

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable tBellOne = null;
            ITrackable tBellTwo = null;
            double distance = 0;

            for(int i = 0; i < locations.Length; i++)
            {

                var latA = locations[i].Location.Latitude;
                var longA = locations[i].Location.Longitude;
                var corA = new GeoCoordinate(latA, longA);

                for (int j = 0; j < locations.Length; j++)
                {
                    var latB = locations[j].Location.Latitude;
                    var longB = locations[j].Location.Longitude;
                    var corB = new GeoCoordinate(latB, longB);

                    if (corB.GetDistanceTo(corA) > distance)
                    {
                        distance = corB.GetDistanceTo(corA);
                        tBellOne = locations[i];
                        tBellTwo = locations[j];
                        
                    }
                }
            }
            Console.WriteLine(tBellOne.Name);
            Console.WriteLine(tBellTwo.Name);
        }


    }
    }