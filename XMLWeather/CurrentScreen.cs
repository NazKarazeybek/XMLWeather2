using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {
            if (Form1.days.Count == 0)
            {
                MessageBox.Show("Weather data failed to load.");
                return;
            }

            // Load today's weather data 
            Day today = Form1.days[0];

            cityOutput.Text = today.location;
            tempLabel.Text = today.currentTemp + "°C";
            minOutput.Text = today.tempLow + "°C";
            maxOutput.Text = today.tempHigh + "°C";
            windSpeedOutput.Text = today.windSpeed + " m/s";
            humidityOutput.Text = today.humidity + " %";

            // Normalize condition to lowercase
            string condition = today.condition?.ToLower() ?? "";

            // === Set weather icon ===
            switch (condition)
            {
                case "clear":
                    weatherIconPB.Image = Properties.Resources.clearIcon;
                    break;
                case "clouds":
                case "cloudy":
                    weatherIconPB.Image = Properties.Resources.cloudyIcon;
                    break;
                case "rain":
                    weatherIconPB.Image = Properties.Resources.rainyIcon;
                    break;
                case "snow":
                case "snowy":
                    weatherIconPB.Image = Properties.Resources.snowyIcon;
                    break;
                case "drizzle":
                    weatherIconPB.Image = Properties.Resources.drizzleIcon;
                    break;
                case "mist":
                case "fog":
                    weatherIconPB.Image = Properties.Resources.mistyIcon;
                    break;
                default:
                    weatherIconPB.Image = Properties.Resources.clearIcon;
                    break;
            }

            // === Set background image based on the weather ===
            switch (condition)
            {
                case "clear":
                    this.BackgroundImage = Properties.Resources.clearBG;
                    break;
                case "clouds":
                case "cloudy":
                    this.BackgroundImage = Properties.Resources.cloudyBG;
                    break;
                case "rain":
                    this.BackgroundImage = Properties.Resources.rainBG;
                    break;
                case "snow":
                case "snowy":
                    this.BackgroundImage = Properties.Resources.snowBG;
                    break;
                case "drizzle":
                    this.BackgroundImage = Properties.Resources.drizzleBG;
                    break;
                case "mist":
                case "fog":
                    this.BackgroundImage = Properties.Resources.mistyBG;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.clearBG;
                    break;
            }

        }

    }
}
