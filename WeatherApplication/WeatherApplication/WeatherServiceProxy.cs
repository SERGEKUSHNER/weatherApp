using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication
{
    public class WeatherServiceProxy
    {
        private const string ServiceURL = "https://api.darksky.net/forecast/afbac69381be299ee92f5dd2887ae966";

        public WeatherResponse GetData(double latitude, double longitude)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string dirtyData = downloadData(string.Format(@"{0}/{1},{2}", ServiceURL, latitude.ToString(nfi), longitude.ToString(nfi)));

            object obj = JsonConvert.DeserializeObject(dirtyData, typeof(WeatherResponse));

            return obj as WeatherResponse;
        }


        private string downloadData(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch
            {
                throw new Exception("Raise In Error Download Data .. Please Check Internet Or API!");
            }
        }
    }
}
