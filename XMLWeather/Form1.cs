using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();

        public static string city = "Fairbanks";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

         
        public void ExtractForecast()
        {
            string urlStart = "http://api.openweathermap.org/data/2.5/forecast/daily?q=";
            string urlEnd = "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(urlStart + city + urlEnd);

            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //find the time element and get the day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");  // Use "name" instead of "value"

                // find wind speed
                reader.ReadToFollowing("windSpeed");
                d.windSpeed = Math.Round(Convert.ToDouble(reader.GetAttribute("mps"))).ToString();

                //find the temperature element and get the min and max attributes
                reader.ReadToFollowing("temperature");
                d.tempLow = Math.Round(Convert.ToDouble(reader.GetAttribute("min"))).ToString();
                d.tempHigh = Math.Round(Convert.ToDouble(reader.GetAttribute("max"))).ToString();

                //find humidity 
                reader.ReadToFollowing("humidity");
                d.humidity = reader.GetAttribute("value");

                //add day to list of days
                days.Add(d);
            }
        }

        public void ExtractCurrent()
        {
            string urlStart = "http://api.openweathermap.org/data/2.5/weather?q=";
            string urlEnd = "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(urlStart + city + urlEnd);

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Math.Round(Convert.ToDouble(reader.GetAttribute("value"))).ToString();

            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");
        }
    }
}
