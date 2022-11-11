using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_class_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num = Randomm(); //rnd.Next();

        }
        int num;
        private int Randomm()
        {
            Random rnd = new Random();
            num = rnd.Next(1, 100);
            return num;
        }
        private void Compare(int number, int guessed_number)
        {
            if (number > guessed_number)
            {
                lbl_feedback.Text = "Guessed number is lower than the random value";

            }
            else if (number < guessed_number)
            {
                lbl_feedback.Text = "Guessed number is higher than the random value";

            }
            else
            {
                lbl_feedback.Text = "You guessed correctly";
            }

        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
          
            int guessed_number = int.Parse(txt_guess.Text);
            Compare(num, guessed_number);

        }
    }
}
