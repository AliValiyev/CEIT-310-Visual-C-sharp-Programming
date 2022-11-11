using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global variables defined [please do not change anything]
        int number1 = 0;
        int number2 = 0;
        int result = 0;


        #region PART1: CHECKING AGAINST INVALID ENTRIES
        /// <summary>
        /// In Part 1, the goal is to display an error message (using MessageBox.Show),
        /// at the momment users enters a non-numeric value in any  of the textboxes.
        /// If the user entry is valid, they should be converted to integer and then 
        /// assigned to number1 or number2 (depending on which textbox).
        /// </summary>
        /// <Difficulty 4 over 5></Difficulty>
        /// <Points  1.0></Points>

        //Text Changed event handler for txt_number1
        //This is created automatically by double-clicking on the txt_number1
        //This event will be triggered when the content of txt_number1 is changed
        //in other words, when user enters or deletes anything txt_number1
        private void txt_number1_TextChanged(object sender, EventArgs e)
        {
            //make a proper call to IsValidInteger method, and print an error message if user entry is INVALID 
            //if it is VALID, calling IsValidInteger method should assign the converted value to number1
            //YOUR CODE GOES HERE
        }

        //Text Changed event handler for txt_number2
        //This is created automatically by double-clicking on the txt_number2
        //This event will be triggered when the content of txt_number2 is changed
        //in other words, when user enters or deletes anything in txt_number2
        private void txt_number2_TextChanged(object sender, EventArgs e)
        {
            //make a proper call to IsValidInteger method, and print an error message if user entry is INVALID 
            //if it is VALID, calling IsValidInteger method should assign the converted value to number2
            //YOUR CODE GOES HERE
        }

        //This method should return true if strValue can be converted to integer, and
        //return the integer value through intValue
        private bool IsValidInteger(string strValue, out int intValue)
        {
            //Two options are possible here, you can choose either:
            //(1)You can use int.TryParse with strValue and out invalue parameters and return its result
            //(2)You can use try-catch -> inside try{} you can use int.Parse to convert strValue to integer, store inside intValue, and return true
            ////////////////////////// -> insdie catch{} you can return false and set intValue to 0
            //YOUR CODE GOES HERE
        }
        #endregion


        #region PART2: MAKING THE CALCULATION
        /// <summary>
        /// In Part 2, the goal is to make the intended computation.
        /// You will need to apply the selected operation on number1 and number2.
        /// number1 and number2 should have been properly set in Part1 above.
        /// </summary>
        /// <Difficulty 2 over 5></Difficulty>
        /// <Points 0.2></Points>


        //Click event handler for = (calculate) button.
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Use if-else-if to check the operation type from cmb_operation 
            //and perform the selected operation (+, -, /, or *)
            //using the number1 and number2.
            //YOUR CODE GOES HERE


            //print the result in txt_result
            //YOUR CODE GOES HERE
        }
        #endregion


        #region PART3: INCREMENTING THE RESULT
        /// <summary>
        /// In Part 3, the goal is to increment the result (obtained after some computation).
        /// There are three buttons: +1, +5, and +10, to increment by 1, 5, or 10 respectively
        /// You need to define the Increment method, and 
        /// make a proper call to this method from the click event handler of each button.
        /// </summary>
        /// <Difficulty 3 over 5></Difficulty>
        /// <Points 0.4></Points>


        private void Increment(int amount)
        {
            //This method should increment the value of result by amount
            //And print the incremented value in txt_result
            //YOUR CODE GOES HERE
        }

        //Click event handler for +1 button
        private void btn_increment1_Click(object sender, EventArgs e)
        {
            //Make a proper call to Increment
            //YOUR CODE GOES HERE
        }

        //Click event handler for +5 button
        private void btn_increment5_Click(object sender, EventArgs e)
        {
            //Make a proper call to Increment
            //YOUR CODE GOES HERE
        }

        //Click event handler for +10 button
        private void btn_increment10_Click(object sender, EventArgs e)
        {
            //Make a proper call to Increment
            //YOUR CODE GOES HERE
        }
        #endregion


        #region PART4: DECREMENTING THE RESULT
        /// <summary>
        /// In Part 4, the goal is to decrement the result (obtained after some computation).
        /// There are three buttons: -1, -5, and -10, to decrement by 1, 5, or 10 respectively
        /// You need to define the Decrement method, and 
        /// make a proper call to this method from the click event handler of each button.
        /// </summary>
        /// <Difficulty 3 over 5></Difficulty>
        /// <Points 0.4></Points>



        //Define a new method called Decrement
        //This method should decrease the value of result by amount
        //And print the decreased value in txt_result
        //YOUR CODE GOES HERE


        //Click event handler for -1 button
        private void btn_decrement1_Click(object sender, EventArgs e)
        {
            //Make a proper call to Decrement
            //YOUR CODE GOES HERE
        }

        //Click event handler for -5 button
        private void btn_decrement5_Click(object sender, EventArgs e)
        {
            //Make a proper call to Decrement
            //YOUR CODE GOES HERE
        }

        //Click event handler for -5 button
        private void btn_decrement10_Click(object sender, EventArgs e)
        {
            //Make a proper call to Decrement
            //YOUR CODE GOES HERE
        }
        #endregion
    }
}
