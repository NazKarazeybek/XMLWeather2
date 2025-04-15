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
                if (condition.ToLower().Contains("snow"))
                {
                    weatherIconPB.Image = Properties.Resources.snowyIcon;
                }
                else if (condition.ToLower().Contains("cloud"))
                {
                    weatherIconPB.Image = Properties.Resources.cloudyIcon;
                }
                else if (condition.ToLower().Contains("rain"))
                {
                    weatherIconPB.Image = Properties.Resources.rainyIcon;
                }
                else if (condition.ToLower().Contains("clear") || condition.ToLower().Contains("sun"))
                {
                    weatherIconPB.Image = Properties.Resources.clearIcon;
                }
                else
                {
                    weatherIconPB.Image = Properties.Resources.clearIcon; // Optional: fallback icon
                }

            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string inputCity = cityInput.Text.Trim();  // Make sure you have a TextBox named searchInput

            if (!string.IsNullOrEmpty(inputCity))
            {
                Form1.city = inputCity;  // Set the new city name

                Form f = this.FindForm();
                f.Controls.Clear();  // Remove all current screens

                // Call the extract methods to get new data
                ((Form1)f).ExtractForecast();
                ((Form1)f).ExtractCurrent();

                // Load the updated screen again
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
        }
    }
}
