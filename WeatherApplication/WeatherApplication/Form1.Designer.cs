namespace WeatherApplication
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.TimeZone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.cloudCover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Longitude
            // 
            this.Longitude.Location = new System.Drawing.Point(70, 31);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(100, 20);
            this.Longitude.TabIndex = 1;
            // 
            // Latitude
            // 
            this.Latitude.Location = new System.Drawing.Point(190, 31);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(100, 20);
            this.Latitude.TabIndex = 2;
            // 
            // TimeZone
            // 
            this.TimeZone.AutoSize = true;
            this.TimeZone.Location = new System.Drawing.Point(70, 108);
            this.TimeZone.Name = "TimeZone";
            this.TimeZone.Size = new System.Drawing.Size(0, 14);
            this.TimeZone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "TimeZone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Summary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Icon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "WindSpeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "cloudCover";
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Location = new System.Drawing.Point(74, 144);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(0, 14);
            this.summary.TabIndex = 10;
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.Location = new System.Drawing.Point(70, 172);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(0, 14);
            this.icon.TabIndex = 11;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(89, 198);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(0, 14);
            this.temperature.TabIndex = 12;
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Location = new System.Drawing.Point(81, 233);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(0, 14);
            this.windSpeed.TabIndex = 13;
            // 
            // cloudCover
            // 
            this.cloudCover.AutoSize = true;
            this.cloudCover.Location = new System.Drawing.Point(81, 272);
            this.cloudCover.Name = "cloudCover";
            this.cloudCover.Size = new System.Drawing.Size(0, 14);
            this.cloudCover.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 505);
            this.Controls.Add(this.cloudCover);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeZone);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.TextBox Latitude;
        private System.Windows.Forms.Label TimeZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label icon;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label cloudCover;
    }
}

