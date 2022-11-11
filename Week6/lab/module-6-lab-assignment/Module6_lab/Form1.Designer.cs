
namespace Module6_lab
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_operation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_increment1 = new System.Windows.Forms.Button();
            this.btn_increment5 = new System.Windows.Forms.Button();
            this.btn_increment10 = new System.Windows.Forms.Button();
            this.btn_decrement10 = new System.Windows.Forms.Button();
            this.btn_decrement5 = new System.Windows.Forms.Button();
            this.btn_decrement1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.Location = new System.Drawing.Point(344, 90);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 29);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "=";
            this.btn_calculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_number1
            // 
            this.txt_number1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_number1.Location = new System.Drawing.Point(51, 91);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(100, 29);
            this.txt_number1.TabIndex = 1;
            this.txt_number1.TextChanged += new System.EventHandler(this.txt_number1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First number";
            // 
            // cmb_operation
            // 
            this.cmb_operation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_operation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_operation.FormattingEnabled = true;
            this.cmb_operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmb_operation.Location = new System.Drawing.Point(158, 91);
            this.cmb_operation.Name = "cmb_operation";
            this.cmb_operation.Size = new System.Drawing.Size(70, 28);
            this.cmb_operation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second number";
            // 
            // txt_number2
            // 
            this.txt_number2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_number2.Location = new System.Drawing.Point(234, 90);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(100, 29);
            this.txt_number2.TabIndex = 3;
            this.txt_number2.TextChanged += new System.EventHandler(this.txt_number2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result";
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_result.Location = new System.Drawing.Point(428, 91);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(100, 29);
            this.txt_result.TabIndex = 5;
            // 
            // btn_increment1
            // 
            this.btn_increment1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_increment1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_increment1.Location = new System.Drawing.Point(51, 145);
            this.btn_increment1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_increment1.Name = "btn_increment1";
            this.btn_increment1.Size = new System.Drawing.Size(76, 31);
            this.btn_increment1.TabIndex = 9;
            this.btn_increment1.Text = "+1";
            this.btn_increment1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_increment1.UseVisualStyleBackColor = false;
            this.btn_increment1.Click += new System.EventHandler(this.btn_increment1_Click);
            // 
            // btn_increment5
            // 
            this.btn_increment5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_increment5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_increment5.Location = new System.Drawing.Point(132, 145);
            this.btn_increment5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_increment5.Name = "btn_increment5";
            this.btn_increment5.Size = new System.Drawing.Size(76, 31);
            this.btn_increment5.TabIndex = 10;
            this.btn_increment5.Text = "+5";
            this.btn_increment5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_increment5.UseVisualStyleBackColor = false;
            this.btn_increment5.Click += new System.EventHandler(this.btn_increment5_Click);
            // 
            // btn_increment10
            // 
            this.btn_increment10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_increment10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_increment10.Location = new System.Drawing.Point(213, 145);
            this.btn_increment10.Margin = new System.Windows.Forms.Padding(0);
            this.btn_increment10.Name = "btn_increment10";
            this.btn_increment10.Size = new System.Drawing.Size(76, 31);
            this.btn_increment10.TabIndex = 11;
            this.btn_increment10.Text = "+10";
            this.btn_increment10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_increment10.UseVisualStyleBackColor = false;
            this.btn_increment10.Click += new System.EventHandler(this.btn_increment10_Click);
            // 
            // btn_decrement10
            // 
            this.btn_decrement10.BackColor = System.Drawing.Color.MistyRose;
            this.btn_decrement10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_decrement10.Location = new System.Drawing.Point(456, 145);
            this.btn_decrement10.Margin = new System.Windows.Forms.Padding(0);
            this.btn_decrement10.Name = "btn_decrement10";
            this.btn_decrement10.Size = new System.Drawing.Size(76, 31);
            this.btn_decrement10.TabIndex = 14;
            this.btn_decrement10.Text = "-10";
            this.btn_decrement10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_decrement10.UseVisualStyleBackColor = false;
            this.btn_decrement10.Click += new System.EventHandler(this.btn_decrement10_Click);
            // 
            // btn_decrement5
            // 
            this.btn_decrement5.BackColor = System.Drawing.Color.MistyRose;
            this.btn_decrement5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_decrement5.Location = new System.Drawing.Point(375, 145);
            this.btn_decrement5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_decrement5.Name = "btn_decrement5";
            this.btn_decrement5.Size = new System.Drawing.Size(76, 31);
            this.btn_decrement5.TabIndex = 13;
            this.btn_decrement5.Text = "-5";
            this.btn_decrement5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_decrement5.UseVisualStyleBackColor = false;
            this.btn_decrement5.Click += new System.EventHandler(this.btn_decrement5_Click);
            // 
            // btn_decrement1
            // 
            this.btn_decrement1.BackColor = System.Drawing.Color.MistyRose;
            this.btn_decrement1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_decrement1.Location = new System.Drawing.Point(294, 145);
            this.btn_decrement1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_decrement1.Name = "btn_decrement1";
            this.btn_decrement1.Size = new System.Drawing.Size(76, 31);
            this.btn_decrement1.TabIndex = 12;
            this.btn_decrement1.Text = "-1";
            this.btn_decrement1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_decrement1.UseVisualStyleBackColor = false;
            this.btn_decrement1.Click += new System.EventHandler(this.btn_decrement1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Simple Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 218);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_decrement10);
            this.Controls.Add(this.btn_decrement5);
            this.Controls.Add(this.btn_decrement1);
            this.Controls.Add(this.btn_increment10);
            this.Controls.Add(this.btn_increment5);
            this.Controls.Add(this.btn_increment1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_number2);
            this.Controls.Add(this.cmb_operation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_number1);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_operation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_increment1;
        private System.Windows.Forms.Button btn_increment5;
        private System.Windows.Forms.Button btn_increment10;
        private System.Windows.Forms.Button btn_decrement10;
        private System.Windows.Forms.Button btn_decrement5;
        private System.Windows.Forms.Button btn_decrement1;
        private System.Windows.Forms.Label label5;
    }
}

