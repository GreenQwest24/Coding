namespace advancedStopWatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.stooBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "00 : 00 : 00 : 00";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.White;
            this.startBTN.Location = new System.Drawing.Point(119, 190);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(160, 60);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stooBTN
            // 
            this.stooBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.stooBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stooBTN.ForeColor = System.Drawing.Color.White;
            this.stooBTN.Location = new System.Drawing.Point(312, 190);
            this.stooBTN.Name = "stooBTN";
            this.stooBTN.Size = new System.Drawing.Size(160, 60);
            this.stooBTN.TabIndex = 2;
            this.stooBTN.Text = "Stop";
            this.stooBTN.UseVisualStyleBackColor = false;
            this.stooBTN.Click += new System.EventHandler(this.stooBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
            this.resetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBTN.ForeColor = System.Drawing.Color.White;
            this.resetBTN.Location = new System.Drawing.Point(504, 190);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(160, 60);
            this.resetBTN.TabIndex = 3;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(786, 301);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.stooBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("DS-Digital", 8F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button stooBTN;
        private System.Windows.Forms.Button resetBTN;
    }
}

