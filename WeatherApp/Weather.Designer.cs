
namespace WeatherApp
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.windspeed = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempFeels = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wCondition = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.windspeed);
            this.groupBox1.Controls.Add(this.pressure);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.humidity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tempFeels);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.temperature);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cityName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.Location = new System.Drawing.Point(454, 97);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(85, 21);
            this.windspeed.TabIndex = 14;
            this.windspeed.Text = "windspeed";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Location = new System.Drawing.Point(426, 65);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(70, 21);
            this.pressure.TabIndex = 13;
            this.pressure.Text = "pressure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(351, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wind Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(351, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pressure:";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(433, 28);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(72, 21);
            this.humidity.TabIndex = 10;
            this.humidity.Text = "humidity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(351, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Humidity:";
            // 
            // tempFeels
            // 
            this.tempFeels.AutoSize = true;
            this.tempFeels.Location = new System.Drawing.Point(237, 97);
            this.tempFeels.Name = "tempFeels";
            this.tempFeels.Size = new System.Drawing.Size(81, 21);
            this.tempFeels.TabIndex = 8;
            this.tempFeels.Text = "tempFeels";
            this.tempFeels.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(110, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Temp Feels like:";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(216, 65);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(96, 21);
            this.temperature.TabIndex = 6;
            this.temperature.Text = "temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperature:";
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Location = new System.Drawing.Point(149, 28);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(76, 21);
            this.cityName.TabIndex = 4;
            this.cityName.Text = "cityName";
            this.cityName.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forecast for the selected city:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(88, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Weather Condition:";
            // 
            // wCondition
            // 
            this.wCondition.AutoSize = true;
            this.wCondition.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wCondition.Location = new System.Drawing.Point(318, 278);
            this.wCondition.Name = "wCondition";
            this.wCondition.Size = new System.Drawing.Size(136, 32);
            this.wCondition.TabIndex = 15;
            this.wCondition.Text = "wCondition";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(663, 382);
            this.Controls.Add(this.wCondition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label tempFeels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wCondition;
    }
}

