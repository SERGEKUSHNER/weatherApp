using System.Collections.Generic;

namespace WeatherApplication
{
    public class WeatherResponse
    {
        public double latitude { get; set; } // x

        public double longitude { get; set; } // y

        public string timezone { get; set; }

        public Data currently { get; set; }

        public Other minutely { get; set; }

        public Other hourly { get; set; }

        public Other daily { get; set; }



        public int offset { get; set; }
    }

    public class CommonData
    {
        public string summary { get; set; }

        public string icon { get; set; }
    }

    public class Data : CommonData
    {
        public string time { get; set; }

        public decimal nearestStormDistance { get; set; }
        public decimal nearestStormBearing { get; set; }

        public decimal precipIntensity { get; set; }
        public decimal precipProbability { get; set; }

        public decimal temperature { get; set; }

        public decimal apparentTemperature { get; set; }

        public decimal dewPoint { get; set; }

        public decimal humidity { get; set; }

        public decimal pressure { get; set; }

        public decimal windSpeed { get; set; }

        public decimal windGust { get; set; }

        public decimal windBearing { get; set; }

        public decimal cloudCover { get; set; }

        public decimal uvIndex { get; set; }


        public decimal visibility { get; set; }

        public string precipType { get; set; }

        public decimal ozone { get; set; }
    }



    public class Other : CommonData
    {
        public List<Data> data { get; set; }
    }



}