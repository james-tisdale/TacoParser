namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogInfo("cell array less than 3 items");
                return null;
            }

            // grab the latitude from your array at index 0
            string latitudeString = cells[0];
            // grab the longitude from your array at index 1
            string longitudeString = cells[1];
            // grab the name from your array at index 2
            string coordName = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double latitude = double.Parse(latitudeString);
            double longitude = double.Parse(longitudeString);

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var tacoBell = new TacoBell();
            tacoBell.Name = coordName;
            Point location = new Point();
            location.Latitude = latitude;
            location.Longitude = longitude;
            tacoBell.Location = location;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            return tacoBell;
        }

    }
}