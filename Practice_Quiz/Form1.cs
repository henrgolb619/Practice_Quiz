using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy Hump Day!";
        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            string username = question2TextBox.Text;
            question2OutputLabel.Text = "Hello, " + username;
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                int num1 = Convert.ToInt32(q3Int1Text.Text);
                int num2 = Convert.ToInt32(q3int2Text.Text);
                question3OutputLabel.Text = " = " + num1 * num2;
            }
            catch
            {
                question3OutputLabel.Text = "Please enter a valid integer.";
            }
        }
    }
}
