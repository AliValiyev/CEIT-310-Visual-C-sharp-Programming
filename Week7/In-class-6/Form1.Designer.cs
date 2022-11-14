
namespace İnclass_6
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
            this.btn_add = new System.Windows.Forms.Button();
            this.tbx_add = new System.Windows.Forms.TextBox();
            this.lb_students = new System.Windows.Forms.ListBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_remove_selected_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(452, 150);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbx_add
            // 
            this.tbx_add.Location = new System.Drawing.Point(301, 150);
            this.tbx_add.Name = "tbx_add";
            this.tbx_add.Size = new System.Drawing.Size(125, 27);
            this.tbx_add.TabIndex = 1;
            this.tbx_add.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_students
            // 
            this.lb_students.FormattingEnabled = true;
            this.lb_students.ItemHeight = 20;
            this.lb_students.Location = new System.Drawing.Point(39, 150);
            this.lb_students.Name = "lb_students";
            this.lb_students.Size = new System.Drawing.Size(150, 184);
            this.lb_students.TabIndex = 2;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(317, 212);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(94, 29);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(452, 212);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(94, 29);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(395, 314);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(94, 29);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_remove_selected_item
            // 
            this.btn_remove_selected_item.Location = new System.Drawing.Point(317, 262);
            this.btn_remove_selected_item.Name = "btn_remove_selected_item";
            this.btn_remove_selected_item.Size = new System.Drawing.Size(229, 29);
            this.btn_remove_selected_item.TabIndex = 6;
            this.btn_remove_selected_item.Text = "Remove Selected Item";
            this.btn_remove_selected_item.UseVisualStyleBackColor = true;
            this.btn_remove_selected_item.Click += new System.EventHandler(this.btn_remove_selected_item_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove_selected_item);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.lb_students);
            this.Controls.Add(this.tbx_add);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tbx_add;
        private System.Windows.Forms.ListBox lb_students;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_remove_selected_item;
    }
}

