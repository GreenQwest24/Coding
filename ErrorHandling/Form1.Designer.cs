namespace ErrorHandling
{
    partial class Form1
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
            label_ClickText = new Label();
            textBox = new TextBox();
            submitButton = new Button();
            comboBox = new ComboBox();
            clearButton = new Button();
            checkBox = new CheckBox();
            emptyText = new Button();
            SuspendLayout();
            // 
            // label_ClickText
            // 
            label_ClickText.AutoSize = true;
            label_ClickText.Location = new Point(308, 199);
            label_ClickText.Name = "label_ClickText";
            label_ClickText.Size = new Size(156, 25);
            label_ClickText.TabIndex = 0;
            label_ClickText.Text = "You Can Dub Click";
            // 
            // textBox
            // 
            textBox.Location = new Point(108, 117);
            textBox.Name = "textBox";
            textBox.Size = new Size(150, 31);
            textBox.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(108, 383);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 2;
            submitButton.Text = "Click";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(499, 115);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(182, 33);
            comboBox.TabIndex = 3;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(569, 383);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(323, 296);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(121, 29);
            checkBox.TabIndex = 6;
            checkBox.Text = "checkBox1";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // emptyText
            // 
            emptyText.Location = new Point(352, 383);
            emptyText.Name = "emptyText";
            emptyText.Size = new Size(112, 34);
            emptyText.TabIndex = 7;
            emptyText.Text = "Empty";
            emptyText.UseVisualStyleBackColor = true;
            emptyText.Click += emptyText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(emptyText);
            Controls.Add(checkBox);
            Controls.Add(clearButton);
            Controls.Add(comboBox);
            Controls.Add(submitButton);
            Controls.Add(textBox);
            Controls.Add(label_ClickText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ClickText;
        private TextBox textBox;
        private Button submitButton;
        private ComboBox comboBox;
        private Button clearButton;
        private CheckBox checkBox;
        private Button emptyText;
    }
}
