using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProgramsForm
{
    public partial class TextProgramis : Form
    {
        public TextProgramis()
        {
            InitializeComponent();
            
            
        }


        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FizzBuzzRun_Click_1(object sender, EventArgs e)
        {
            
            
            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    FizzBuzzOutput.Text += "FizzBuzz\t";
                }
                else if ((i % 5) == 0)
                {
                    FizzBuzzOutput.Text += "Buzz\t";
                }
                else if ((i % 3) == 0)
                {
                    FizzBuzzOutput.Text += "Fizz\t";
                }
                else
                {
                    if(i == 1)
                    {
                        FizzBuzzOutput.Text += "\t";
                    }
                    FizzBuzzOutput.Text += i + "\t";
                }
            }
        }

        private void RSButRun_Click(object sender, EventArgs e)
        {
           
            // initilise the output text incase this isnt the first time the program ran
            ReverseStringOutput.Text = "";
            for (int i=0; i< reverseStringInput.TextLength; i++)
            {
                ReverseStringOutput.Text += reverseStringInput.Text[reverseStringInput.TextLength - i - 1];
            }
        }

        private void PigLatRun_Click(object sender, EventArgs e)
        {
                
        }
    }
}
