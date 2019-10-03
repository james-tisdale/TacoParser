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
            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                logger.LogInfo("cell array less than 3 items");
                return null;
            }

            string latitudeString = cells[0];
            string longitudeString = cells[1];
            string coordName = cells[2];

            double latitude = double.Parse(latitudeString);
            double longitude = double.Parse(longitudeString);

            var tacoBell = new TacoBell();
            tacoBell.Name = coordName;
            Point location = new Point();
            location.Latitude = latitude;
            location.Longitude = longitude;
            tacoBell.Location = location;

            return tacoBell;
        }

    }
}