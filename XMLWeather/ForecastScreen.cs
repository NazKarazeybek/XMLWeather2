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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {

        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {
            // Display forecast starting from day 1 (day 0 is current)

            // Day 1 forecast
            date01.Text = FormatDate(Form1.days[1].date);
            max1.Text = Form1.days[1].tempHigh + "°C";
            min1.Text = Form1.days[1].tempLow + "°C";
            icon1.Image = GetWeatherIcon(Form1.days[1].condition);
            // Day 2 forecast
            date2.Text = FormatDate(Form1.days[2].date);
            max2.Text = Form1.days[2].tempHigh + "°C";
            min2.Text = Form1.days[2].tempLow + "°C";
            icon2.Image = GetWeatherIcon(Form1.days[2].condition);
            // Day 3 forecast
            date3.Text = FormatDate(Form1.days[3].date);
            max3.Text = Form1.days[3].tempHigh + "°C";
            min3.Text = Form1.days[3].tempLow + "°C";
            icon3.Image = GetWeatherIcon(Form1.days[3].condition);
            // Day 4 forecast
            date4.Text = FormatDate(Form1.days[4].date);
            max4.Text = Form1.days[4].tempHigh + "°C";
            min4.Text = Form1.days[4].tempLow + "°C";
            icon4.Image = GetWeatherIcon(Form1.days[4].condition);
            // Day 5 forecast
            date5.Text = FormatDate(Form1.days[5].date);
            max5.Text = Form1.days[5].tempHigh + "°C";
            min5.Text = Form1.days[5].tempLow + "°C";
            icon5.Image = GetWeatherIcon(Form1.days[5].condition);
        }

        private Image GetWeatherIcon(string condition)
        {
            string cond = condition?.ToLower() ?? "";

            switch (cond)
            {
                case "clear":
                    return Properties.Resources.smallClearIcon;
                case "clouds":
                case "cloudy":
                    return Properties.Resources.smallCloudyIcon;
                case "rain":
                    return Properties.Resources.smallRainIcon;
                case "snow":
                case "snowy":
                    return Properties.Resources.smallSnowyIcon;
                case "drizzle":
                    return Properties.Resources.smallDrizzleIcon;
                case "mist":
                case "fog":
                    return Properties.Resources.smallMistyIcon;
                default:
                    return Properties.Resources.smallClearIcon;
            }
        }
        private string FormatDate(string rawDate)
        {
            DateTime dt;
            if (DateTime.TryParse(rawDate, out dt))
            {
                return dt.ToString("MMMM d") + GetDaySuffix(dt.Day);
            }
            else
            {
                return rawDate; // fallback if parsing fails
            }
        }

        private string GetDaySuffix(int day)
        {
            if (day >= 11 && day <= 13) return "th";

            switch (day % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }

    }
}
