namespace M7IndividualActivitiy
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
            this.gbox_selectOption = new System.Windows.Forms.GroupBox();
            this.rb_endsWith = new System.Windows.Forms.RadioButton();
            this.rb_startsWith = new System.Windows.Forms.RadioButton();
            this.rb_contains = new System.Windows.Forms.RadioButton();
            this.textbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_report = new System.Windows.Forms.Label();
            this.gbox_selectOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_selectOption
            // 
            this.gbox_selectOption.Controls.Add(this.rb_endsWith);
            this.gbox_selectOption.Controls.Add(this.rb_startsWith);
            this.gbox_selectOption.Controls.Add(this.rb_contains);
            this.gbox_selectOption.Location = new System.Drawing.Point(118, 84);
            this.gbox_selectOption.Name = "gbox_selectOption";
            this.gbox_selectOption.Size = new System.Drawing.Size(317, 82);
            this.gbox_selectOption.TabIndex = 0;
            this.gbox_selectOption.TabStop = false;
            this.gbox_selectOption.Text = "Search Option";
            // 
            // rb_endsWith
            // 
            this.rb_endsWith.AutoSize = true;
            this.rb_endsWith.Location = new System.Drawing.Point(211, 40);
            this.rb_endsWith.Name = "rb_endsWith";
            this.rb_endsWith.Size = new System.Drawing.Size(96, 24);
            this.rb_endsWith.TabIndex = 2;
            this.rb_endsWith.Text = "Ends With";
            this.rb_endsWith.UseVisualStyleBackColor = true;
            // 
            // rb_startsWith
            // 
            this.rb_startsWith.AutoSize = true;
            this.rb_startsWith.Location = new System.Drawing.Point(103, 40);
            this.rb_startsWith.Name = "rb_startsWith";
            this.rb_startsWith.Size = new System.Drawing.Size(102, 24);
            this.rb_startsWith.TabIndex = 1;
            this.rb_startsWith.Text = "Starts With";
            this.rb_startsWith.UseVisualStyleBackColor = true;
            // 
            // rb_contains
            // 
            this.rb_contains.AutoSize = true;
            this.rb_contains.Checked = true;
            this.rb_contains.Location = new System.Drawing.Point(10, 40);
            this.rb_contains.Name = "rb_contains";
            this.rb_contains.Size = new System.Drawing.Size(87, 24);
            this.rb_contains.TabIndex = 0;
            this.rb_contains.TabStop = true;
            this.rb_contains.Text = "Contains";
            this.rb_contains.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(118, 181);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(317, 27);
            this.textbox.TabIndex = 1;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(118, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.Location = new System.Drawing.Point(300, 237);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(50, 20);
            this.lb_report.TabIndex = 3;
            this.lb_report.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_report);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.gbox_selectOption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_selectOption.ResumeLayout(false);
            this.gbox_selectOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_selectOption;
        private System.Windows.Forms.RadioButton rb_endsWith;
        private System.Windows.Forms.RadioButton rb_startsWith;
        private System.Windows.Forms.RadioButton rb_contains;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_report;
    }
}
