namespace in_class_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_contains = new System.Windows.Forms.RadioButton();
            this.rb_start = new System.Windows.Forms.RadioButton();
            this.rb_end = new System.Windows.Forms.RadioButton();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_mean = new System.Windows.Forms.Label();
            this.lbl_number_of_scores1 = new System.Windows.Forms.Label();
            this.lbl_number_of_scores2 = new System.Windows.Forms.Label();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.tb_filter);
            this.groupBox1.Controls.Add(this.lbl_number_of_scores2);
            this.groupBox1.Controls.Add(this.lbl_number_of_scores1);
            this.groupBox1.Controls.Add(this.lbl_mean);
            this.groupBox1.Controls.Add(this.lbl_min);
            this.groupBox1.Controls.Add(this.lbl_max);
            this.groupBox1.Controls.Add(this.rb_end);
            this.groupBox1.Controls.Add(this.rb_start);
            this.groupBox1.Controls.Add(this.rb_contains);
            this.groupBox1.Location = new System.Drawing.Point(227, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb_contains
            // 
            this.rb_contains.AutoSize = true;
            this.rb_contains.Location = new System.Drawing.Point(29, 32);
            this.rb_contains.Name = "rb_contains";
            this.rb_contains.Size = new System.Drawing.Size(72, 19);
            this.rb_contains.TabIndex = 0;
            this.rb_contains.TabStop = true;
            this.rb_contains.Text = "Contains";
            this.rb_contains.UseVisualStyleBackColor = true;
            // 
            // rb_start
            // 
            this.rb_start.AutoSize = true;
            this.rb_start.Location = new System.Drawing.Point(129, 32);
            this.rb_start.Name = "rb_start";
            this.rb_start.Size = new System.Drawing.Size(80, 19);
            this.rb_start.TabIndex = 1;
            this.rb_start.TabStop = true;
            this.rb_start.Text = "Starts with";
            this.rb_start.UseVisualStyleBackColor = true;
            // 
            // rb_end
            // 
            this.rb_end.AutoSize = true;
            this.rb_end.Location = new System.Drawing.Point(242, 32);
            this.rb_end.Name = "rb_end";
            this.rb_end.Size = new System.Drawing.Size(76, 19);
            this.rb_end.TabIndex = 2;
            this.rb_end.TabStop = true;
            this.rb_end.Text = "Ends with";
            this.rb_end.UseVisualStyleBackColor = true;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(390, 50);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(75, 15);
            this.lbl_max.TabIndex = 3;
            this.lbl_max.Text = "Max score is:";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(390, 78);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(73, 15);
            this.lbl_min.TabIndex = 4;
            this.lbl_min.Text = "Min score is:";
            // 
            // lbl_mean
            // 
            this.lbl_mean.AutoSize = true;
            this.lbl_mean.Location = new System.Drawing.Point(390, 111);
            this.lbl_mean.Name = "lbl_mean";
            this.lbl_mean.Size = new System.Drawing.Size(82, 15);
            this.lbl_mean.TabIndex = 5;
            this.lbl_mean.Text = "Mean score is:";
            // 
            // lbl_number_of_scores1
            // 
            this.lbl_number_of_scores1.AutoSize = true;
            this.lbl_number_of_scores1.Location = new System.Drawing.Point(390, 145);
            this.lbl_number_of_scores1.Name = "lbl_number_of_scores1";
            this.lbl_number_of_scores1.Size = new System.Drawing.Size(98, 15);
            this.lbl_number_of_scores1.TabIndex = 6;
            this.lbl_number_of_scores1.Text = "# of scores >=60:";
            // 
            // lbl_number_of_scores2
            // 
            this.lbl_number_of_scores2.AutoSize = true;
            this.lbl_number_of_scores2.Location = new System.Drawing.Point(390, 175);
            this.lbl_number_of_scores2.Name = "lbl_number_of_scores2";
            this.lbl_number_of_scores2.Size = new System.Drawing.Size(91, 15);
            this.lbl_number_of_scores2.TabIndex = 7;
            this.lbl_number_of_scores2.Text = "# of Scores <60:";
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(29, 57);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(289, 23);
            this.tb_filter.TabIndex = 2;
            this.tb_filter.TextChanged += new System.EventHandler(this.tb_filter_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(29, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 124);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox tb_filter;
        private Label lbl_number_of_scores2;
        private Label lbl_number_of_scores1;
        private Label lbl_mean;
        private Label lbl_min;
        private Label lbl_max;
        private RadioButton rb_end;
        private RadioButton rb_start;
        private RadioButton rb_contains;
    }
}