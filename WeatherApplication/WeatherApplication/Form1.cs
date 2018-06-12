using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApplication
{
    public partial class Form1 : Form
    {


        WeatherResponse obj;

        public Form1()
        {
            InitializeComponent();

           
           
        }
             

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherServiceProxy weatherData = new WeatherServiceProxy();
          double Longit = Convert.ToDouble(Longitude.Text);
          double Latit = Convert.ToDouble(Latitude.Text);
          this.obj = weatherData.GetData(Longit, Latit);

            TimeZone.Text = obj.timezone;
            summary.Text = obj.currently.summary;
            icon.Text = obj.currently.icon;
            temperature.Text =Convert.ToString(obj.currently.temperature);
            windSpeed.Text = Convert.ToString(obj.currently.windSpeed);
            cloudCover.Text = Convert.ToString(obj.currently.cloudCover);
        }

        private string ToDouble(string longitude)
        {
            throw new NotImplementedException();
        }


    }
}
