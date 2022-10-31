
namespace in_class_4
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
            this.txt_num_2 = new System.Windows.Forms.TextBox();
            this.txt_num_1 = new System.Windows.Forms.TextBox();
            this.lbl_rez = new System.Windows.Forms.Label();
            this.cb_comp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_num_2
            // 
            this.txt_num_2.Location = new System.Drawing.Point(153, 204);
            this.txt_num_2.Name = "txt_num_2";
            this.txt_num_2.Size = new System.Drawing.Size(125, 27);
            this.txt_num_2.TabIndex = 0;
            // 
            // txt_num_1
            // 
            this.txt_num_1.Location = new System.Drawing.Point(153, 144);
            this.txt_num_1.Name = "txt_num_1";
            this.txt_num_1.Size = new System.Drawing.Size(125, 27);
            this.txt_num_1.TabIndex = 1;
            // 
            // lbl_rez
            // 
            this.lbl_rez.AutoSize = true;
            this.lbl_rez.Location = new System.Drawing.Point(553, 180);
            this.lbl_rez.Name = "lbl_rez";
            this.lbl_rez.Size = new System.Drawing.Size(45, 20);
            this.lbl_rez.TabIndex = 3;
            this.lbl_rez.Text = "result";
            // 
            // cb_comp
            // 
            this.cb_comp.FormattingEnabled = true;
            this.cb_comp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cb_comp.Location = new System.Drawing.Point(309, 172);
            this.cb_comp.Name = "cb_comp";
            this.cb_comp.Size = new System.Drawing.Size(151, 28);
            this.cb_comp.TabIndex = 4;
            this.cb_comp.SelectedIndexChanged += new System.EventHandler(this.cb_comp_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_comp);
            this.Controls.Add(this.lbl_rez);
            this.Controls.Add(this.txt_num_1);
            this.Controls.Add(this.txt_num_2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num_2;
        private System.Windows.Forms.TextBox txt_num_1;
        private System.Windows.Forms.Label lbl_rez;
        private System.Windows.Forms.ComboBox cb_comp;
    }
}

