using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double value;
        double sum = 0;
        double counter = 0;
        double average;

        private void AddButton_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(InputTextBox.Text);

            if (value > 0)
            {
                counter++;
                sum = sum + value;
                OutputTextBox.Text = $"{value} was added to the sum";
                InputTextBox.Text = "";
            }
            else if (value == 0 )
            {
                average = sum / counter;
                OutputTextBox.Text = $"The average of all numbers entered is {average}";
                InputTextBox.Text = "";
            }
            
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
            sum = 0;
            average = 0;
            counter = 0;
        }
    }
}
