namespace WeatherApp
{
    partial class MainForm
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
            this.btnStartListening = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(177, 325);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(115, 50);
            this.btnStartListening.TabIndex = 0;
            this.btnStartListening.Text = "BEGIN";
            this.btnStartListening.UseVisualStyleBackColor = true;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(88, 72);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(51, 20);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "label1";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(88, 159);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(51, 20);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "label2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(88, 240);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "label3";
            // 
            // btnStopListening
            // 
            this.btnStopListening.Location = new System.Drawing.Point(426, 325);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(109, 50);
            this.btnStopListening.TabIndex = 5;
            this.btnStopListening.Text = "STOP";
            this.btnStopListening.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(291, 153);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(306, 26);
            this.txtCity.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.btnStartListening);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.TextBox txtCity;
    }
}

