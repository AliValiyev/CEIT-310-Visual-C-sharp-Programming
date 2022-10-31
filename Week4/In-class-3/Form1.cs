using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_class_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double averageBill, averageTip=0 ;
        double averageCounter = 0;

        private void btn_tip_Click(object sender, EventArgs e)
        {
            double bill = double.Parse(txt_bill.Text);
            double tipPercentage = double.Parse(txt_percentage.Text)/100;
            double tip = bill * tipPercentage;
            lbl_tip.Text = tip.ToString();
            averageBill = averageBill + bill;
            averageTip = averageTip + tip;
            averageCounter = averageCounter + 1;
            double averageBillform = averageBill / averageCounter;
            double averageTipform = averageTip / averageCounter;
            lbl_averageBill.Text = averageBillform.ToString();
            lbl_averageTip.Text = averageTipform.ToString();



        }
    }
}
