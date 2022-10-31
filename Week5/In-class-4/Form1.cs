using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_class_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rez;
            if (int.TryParse(txt_num_1.Text, out int num1) == false)
            { MessageBox.Show("Invalid entry(number 1)");
            }
            if (int.TryParse(txt_num_2.Text, out int num2) == false)
            {
                MessageBox.Show("Invalid entry(number 2)");
            }
            else
            {  if (cb_comp.SelectedItem.ToString()== "+")
                {
                    rez = num1 + num2;
                    lbl_rez.Text = rez.ToString();
                }
                else if (cb_comp.SelectedItem.ToString() == "-")
                {
                    rez = num1 - num2;
                    lbl_rez.Text = rez.ToString();
                }
                else if (cb_comp.SelectedItem.ToString() == "*")
                {
                    rez = num1 * num2;
                    lbl_rez.Text = rez.ToString();
                }
                else if (cb_comp.SelectedItem.ToString() == "/")
                {
                    rez = num1 / num2;
                    lbl_rez.Text = rez.ToString();
                }
                
            }
}
    }
}