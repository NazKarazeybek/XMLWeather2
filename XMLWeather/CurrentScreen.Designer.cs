namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weatherIconPB = new System.Windows.Forms.PictureBox();
            this.humidityIcon = new System.Windows.Forms.PictureBox();
            this.windIcon = new System.Windows.Forms.PictureBox();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.windSpeedOutput = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Azure;
            this.cityOutput.Location = new System.Drawing.Point(61, 59);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(205, 46);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.LightCyan;
            this.maxOutput.Location = new System.Drawing.Point(201, 301);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(46, 28);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.maxLabel.Location = new System.Drawing.Point(177, 301);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(28, 28);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "H";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.LightCyan;
            this.minOutput.Location = new System.Drawing.Point(125, 301);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(46, 28);
            this.minOutput.TabIndex = 30;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.minLabel.Location = new System.Drawing.Point(103, 301);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(25, 28);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "L";
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Azure;
            this.tempLabel.Location = new System.Drawing.Point(20, 250);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(299, 51);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Temperature";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(30, 474);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(92, 35);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(236, 479);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 35);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIconPB
            // 
            this.weatherIconPB.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconPB.Location = new System.Drawing.Point(102, 117);
            this.weatherIconPB.Name = "weatherIconPB";
            this.weatherIconPB.Size = new System.Drawing.Size(130, 130);
            this.weatherIconPB.TabIndex = 43;
            this.weatherIconPB.TabStop = false;
            // 
            // humidityIcon
            // 
            this.humidityIcon.BackColor = System.Drawing.Color.Transparent;
            this.humidityIcon.Image = ((System.Drawing.Image)(resources.GetObject("humidityIcon.Image")));
            this.humidityIcon.Location = new System.Drawing.Point(35, 378);
            this.humidityIcon.Name = "humidityIcon";
            this.humidityIcon.Size = new System.Drawing.Size(50, 51);
            this.humidityIcon.TabIndex = 44;
            this.humidityIcon.TabStop = false;
            // 
            // windIcon
            // 
            this.windIcon.BackColor = System.Drawing.Color.Transparent;
            this.windIcon.Image = ((System.Drawing.Image)(resources.GetObject("windIcon.Image")));
            this.windIcon.Location = new System.Drawing.Point(180, 378);
            this.windIcon.Name = "windIcon";
            this.windIcon.Size = new System.Drawing.Size(50, 51);
            this.windIcon.TabIndex = 45;
            this.windIcon.TabStop = false;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(91, 378);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(78, 33);
            this.humidityOutput.TabIndex = 46;
            // 
            // windSpeedOutput
            // 
            this.windSpeedOutput.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedOutput.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedOutput.ForeColor = System.Drawing.Color.White;
            this.windSpeedOutput.Location = new System.Drawing.Point(236, 378);
            this.windSpeedOutput.Name = "windSpeedOutput";
            this.windSpeedOutput.Size = new System.Drawing.Size(96, 31);
            this.windSpeedOutput.TabIndex = 47;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(93, 410);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(78, 21);
            this.humidityLabel.TabIndex = 48;
            this.humidityLabel.Text = "Humidity";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.windSpeedLabel.Location = new System.Drawing.Point(238, 408);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(94, 21);
            this.windSpeedLabel.TabIndex = 49;
            this.windSpeedLabel.Text = "Wind Speed";
            // 
            // cityInput
            // 
            this.cityInput.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cityInput.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.ForeColor = System.Drawing.Color.White;
            this.cityInput.Location = new System.Drawing.Point(22, 15);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(128, 29);
            this.cityInput.TabIndex = 50;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(157, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 51;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.windSpeedOutput);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.windIcon);
            this.Controls.Add(this.humidityIcon);
            this.Controls.Add(this.weatherIconPB);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(340, 543);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox weatherIconPB;
        private System.Windows.Forms.PictureBox humidityIcon;
        private System.Windows.Forms.PictureBox windIcon;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label windSpeedOutput;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button searchButton;
    }
}
