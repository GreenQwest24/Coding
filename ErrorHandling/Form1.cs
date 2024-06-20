using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErrorHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /* private void MainForm_Load(object sender, EventArgs e)
         {
             // Populate the combo box with some items
             comboBox.Items.Add("Option 1");
             comboBox.Items.Add("Option 2");
             comboBox.Items.Add("Option 3");
         }*/
         //
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                label_ClickText.Text = "Laurence";
            }
            else
            {
                MessageBox.Show("User needs to checkbox!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox.Checked)
                {

                    MessageBox.Show("CheckBox!");

                }

                else
                {
                    throw new Exception(" Test.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter some text in the TextBox.");
                Console.WriteLine($"Invalid Input!", ex.Message);


            }
        }

        private void emptyText_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text == "")
                {
                    throw new Exception("Resubmit");

                }
                else
                {
                    textBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter some text in the TextBox.");
                Console.WriteLine($"Invalid Input!", ex.Message);

            }
        }
    }
}



