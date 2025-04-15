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
        }
        private void todayLabel_Click(object sender, EventArgs e)
        {
            // When the "Today" label is clicked, switch to the CurrentScreen
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
            //showing weather icon accordingly to the condition (i used if statements instead of switch not to make it strict)
            string cond = condition?.ToLower() ?? "";

            if (cond.Contains("clear"))
            {
                return Properties.Resources.smallClearIcon;
            }
            else if (cond.Contains("cloud"))
            {
                return Properties.Resources.smallCloudyIcon;
            }
            else if (cond.Contains("rain"))
            {
                return Properties.Resources.smallRainIcon;
            }
            else if (cond.Contains("snow"))
            {
                return Properties.Resources.smallSnowyIcon;
            }
            else if (cond.Contains("drizzle"))
            {
                return Properties.Resources.smallDrizzleIcon;
            }
            else if (cond.Contains("mist") || cond.Contains("fog"))
            {
                return Properties.Resources.smallMistyIcon;
            }
            else
            {
                return Properties.Resources.smallClearIcon; // default fallback
            }
        }

        private string FormatDate(string rawDate)
        {
            // Convert the raw date string to a DateTime object
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
            // Determine the suffix for the day of the month
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
