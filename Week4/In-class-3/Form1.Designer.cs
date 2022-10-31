
namespace in_class_3
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
            this.btn_tip = new System.Windows.Forms.Button();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_percentage = new System.Windows.Forms.TextBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lbl_averageBill = new System.Windows.Forms.Label();
            this.lbl_averageTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tip
            // 
            this.btn_tip.Location = new System.Drawing.Point(211, 132);
            this.btn_tip.Name = "btn_tip";
            this.btn_tip.Size = new System.Drawing.Size(94, 29);
            this.btn_tip.TabIndex = 0;
            this.btn_tip.Text = "Total tip";
            this.btn_tip.UseVisualStyleBackColor = true;
            this.btn_tip.Click += new System.EventHandler(this.btn_tip_Click);
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(46, 97);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(125, 27);
            this.txt_bill.TabIndex = 1;
            // 
            // txt_percentage
            // 
            this.txt_percentage.Location = new System.Drawing.Point(46, 160);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(125, 27);
            this.txt_percentage.TabIndex = 2;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(382, 132);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(0, 20);
            this.lbl_tip.TabIndex = 3;
            // 
            // lbl_averageBill
            // 
            this.lbl_averageBill.AutoSize = true;
            this.lbl_averageBill.Location = new System.Drawing.Point(71, 247);
            this.lbl_averageBill.Name = "lbl_averageBill";
            this.lbl_averageBill.Size = new System.Drawing.Size(50, 20);
            this.lbl_averageBill.TabIndex = 4;
            this.lbl_averageBill.Text = "label1";
            // 
            // lbl_averageTip
            // 
            this.lbl_averageTip.AutoSize = true;
            this.lbl_averageTip.Location = new System.Drawing.Point(71, 294);
            this.lbl_averageTip.Name = "lbl_averageTip";
            this.lbl_averageTip.Size = new System.Drawing.Size(50, 20);
            this.lbl_averageTip.TabIndex = 5;
            this.lbl_averageTip.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_averageTip);
            this.Controls.Add(this.lbl_averageBill);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.txt_percentage);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.btn_tip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tip;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_percentage;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_averageBill;
        private System.Windows.Forms.Label lbl_averageTip;
    }
}

