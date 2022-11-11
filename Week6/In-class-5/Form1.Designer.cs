
namespace in_class_5
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
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_guess
            // 
            this.txt_guess.Location = new System.Drawing.Point(26, 121);
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(260, 27);
            this.txt_guess.TabIndex = 0;
            this.txt_guess.Text = "Enter the guessed number here.";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(75, 187);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Location = new System.Drawing.Point(342, 124);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(72, 20);
            this.lbl_feedback.TabIndex = 2;
            this.lbl_feedback.Text = "Feedback";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_guess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_guess;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_feedback;
    }
}

