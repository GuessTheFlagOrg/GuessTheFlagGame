using System;
using System.Drawing;

namespace GuessTheFlagGame
{
    public class Flag
    {
        public string CountryName { get; set; }
        public Image FlagImage { get; set; }

        public Flag(string countryName, Image flagImage)
        {
            CountryName = countryName;
            FlagImage = flagImage;
        }
    }
}
