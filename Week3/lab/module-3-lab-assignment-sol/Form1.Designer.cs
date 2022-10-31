namespace module3_lab_ali_vlyv
{
    partial class frm_user_registration_application
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
            this.tc_user_registration = new System.Windows.Forms.TabControl();
            this.tp_profile_info = new System.Windows.Forms.TabPage();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.btn_next_profile_info = new System.Windows.Forms.Button();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.tp_address_info = new System.Windows.Forms.TabPage();
            this.lbl_address_line = new System.Windows.Forms.Label();
            this.tb_address_line = new System.Windows.Forms.TextBox();
            this.cb_address_type = new System.Windows.Forms.ComboBox();
            this.lbl_address_type = new System.Windows.Forms.Label();
            this.btn_next_address_info = new System.Windows.Forms.Button();
            this.btn_back_address_info = new System.Windows.Forms.Button();
            this.tp_summary = new System.Windows.Forms.TabPage();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tc_user_registration.SuspendLayout();
            this.tp_profile_info.SuspendLayout();
            this.tp_address_info.SuspendLayout();
            this.tp_summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_user_registration
            // 
            this.tc_user_registration.Controls.Add(this.tp_profile_info);
            this.tc_user_registration.Controls.Add(this.tp_address_info);
            this.tc_user_registration.Controls.Add(this.tp_summary);
            this.tc_user_registration.Location = new System.Drawing.Point(182, 99);
            this.tc_user_registration.Name = "tc_user_registration";
            this.tc_user_registration.SelectedIndex = 0;
            this.tc_user_registration.Size = new System.Drawing.Size(415, 308);
            this.tc_user_registration.TabIndex = 0;
            // 
            // tp_profile_info
            // 
            this.tp_profile_info.Controls.Add(this.lbl_email);
            this.tp_profile_info.Controls.Add(this.tb_email);
            this.tp_profile_info.Controls.Add(this.lbl_last_name);
            this.tp_profile_info.Controls.Add(this.tb_last_name);
            this.tp_profile_info.Controls.Add(this.btn_next_profile_info);
            this.tp_profile_info.Controls.Add(this.lbl_first_name);
            this.tp_profile_info.Controls.Add(this.tb_first_name);
            this.tp_profile_info.Location = new System.Drawing.Point(4, 24);
            this.tp_profile_info.Name = "tp_profile_info";
            this.tp_profile_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_profile_info.Size = new System.Drawing.Size(407, 280);
            this.tp_profile_info.TabIndex = 0;
            this.tp_profile_info.Text = "Profile Info";
            this.tp_profile_info.UseVisualStyleBackColor = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(46, 114);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 15);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email :";
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Location = new System.Drawing.Point(133, 112);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(202, 23);
            this.tb_email.TabIndex = 14;
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Location = new System.Drawing.Point(46, 71);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(69, 15);
            this.lbl_last_name.TabIndex = 11;
            this.lbl_last_name.Text = "Last Name :";
            // 
            // tb_last_name
            // 
            this.tb_last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_last_name.Location = new System.Drawing.Point(133, 69);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(202, 23);
            this.tb_last_name.TabIndex = 12;
            // 
            // btn_next_profile_info
            // 
            this.btn_next_profile_info.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_next_profile_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next_profile_info.Location = new System.Drawing.Point(242, 164);
            this.btn_next_profile_info.Name = "btn_next_profile_info";
            this.btn_next_profile_info.Size = new System.Drawing.Size(93, 37);
            this.btn_next_profile_info.TabIndex = 10;
            this.btn_next_profile_info.Text = "Next";
            this.btn_next_profile_info.UseVisualStyleBackColor = false;
            this.btn_next_profile_info.Click += new System.EventHandler(this.btn_next_profile_info_Click);
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Location = new System.Drawing.Point(46, 28);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(70, 15);
            this.lbl_first_name.TabIndex = 8;
            this.lbl_first_name.Text = "First Name :";
            // 
            // tb_first_name
            // 
            this.tb_first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_first_name.Location = new System.Drawing.Point(133, 26);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(202, 23);
            this.tb_first_name.TabIndex = 9;
            // 
            // tp_address_info
            // 
            this.tp_address_info.Controls.Add(this.lbl_address_line);
            this.tp_address_info.Controls.Add(this.tb_address_line);
            this.tp_address_info.Controls.Add(this.cb_address_type);
            this.tp_address_info.Controls.Add(this.lbl_address_type);
            this.tp_address_info.Controls.Add(this.btn_next_address_info);
            this.tp_address_info.Controls.Add(this.btn_back_address_info);
            this.tp_address_info.Location = new System.Drawing.Point(4, 24);
            this.tp_address_info.Name = "tp_address_info";
            this.tp_address_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_address_info.Size = new System.Drawing.Size(407, 280);
            this.tp_address_info.TabIndex = 1;
            this.tp_address_info.Text = "Address Info ";
            this.tp_address_info.UseVisualStyleBackColor = true;
            this.tp_address_info.Click += new System.EventHandler(this.tp_address_info_Click);
            // 
            // lbl_address_line
            // 
            this.lbl_address_line.AutoSize = true;
            this.lbl_address_line.Location = new System.Drawing.Point(52, 85);
            this.lbl_address_line.Name = "lbl_address_line";
            this.lbl_address_line.Size = new System.Drawing.Size(80, 15);
            this.lbl_address_line.TabIndex = 16;
            this.lbl_address_line.Text = "Address Line :";
            // 
            // tb_address_line
            // 
            this.tb_address_line.Location = new System.Drawing.Point(138, 85);
            this.tb_address_line.Multiline = true;
            this.tb_address_line.Name = "tb_address_line";
            this.tb_address_line.Size = new System.Drawing.Size(190, 77);
            this.tb_address_line.TabIndex = 15;
            // 
            // cb_address_type
            // 
            this.cb_address_type.FormattingEnabled = true;
            this.cb_address_type.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cb_address_type.Location = new System.Drawing.Point(138, 43);
            this.cb_address_type.Name = "cb_address_type";
            this.cb_address_type.Size = new System.Drawing.Size(190, 23);
            this.cb_address_type.TabIndex = 14;
            // 
            // lbl_address_type
            // 
            this.lbl_address_type.AutoSize = true;
            this.lbl_address_type.Location = new System.Drawing.Point(50, 46);
            this.lbl_address_type.Name = "lbl_address_type";
            this.lbl_address_type.Size = new System.Drawing.Size(82, 15);
            this.lbl_address_type.TabIndex = 13;
            this.lbl_address_type.Text = "Address Type :";
            this.lbl_address_type.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_next_address_info
            // 
            this.btn_next_address_info.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_next_address_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next_address_info.Location = new System.Drawing.Point(253, 189);
            this.btn_next_address_info.Name = "btn_next_address_info";
            this.btn_next_address_info.Size = new System.Drawing.Size(75, 37);
            this.btn_next_address_info.TabIndex = 12;
            this.btn_next_address_info.Text = "Next";
            this.btn_next_address_info.UseVisualStyleBackColor = false;
            this.btn_next_address_info.Click += new System.EventHandler(this.btn_next_address_info_Click);
            // 
            // btn_back_address_info
            // 
            this.btn_back_address_info.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_back_address_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back_address_info.Location = new System.Drawing.Point(156, 189);
            this.btn_back_address_info.Name = "btn_back_address_info";
            this.btn_back_address_info.Size = new System.Drawing.Size(75, 37);
            this.btn_back_address_info.TabIndex = 11;
            this.btn_back_address_info.Text = "Back";
            this.btn_back_address_info.UseVisualStyleBackColor = false;
            this.btn_back_address_info.Click += new System.EventHandler(this.btn_back_address_info_Click);
            // 
            // tp_summary
            // 
            this.tp_summary.Controls.Add(this.lbl_summary);
            this.tp_summary.Controls.Add(this.btn_complete);
            this.tp_summary.Controls.Add(this.button3);
            this.tp_summary.Location = new System.Drawing.Point(4, 24);
            this.tp_summary.Name = "tp_summary";
            this.tp_summary.Padding = new System.Windows.Forms.Padding(3);
            this.tp_summary.Size = new System.Drawing.Size(407, 280);
            this.tp_summary.TabIndex = 2;
            this.tp_summary.Text = "Summary";
            this.tp_summary.UseVisualStyleBackColor = true;
            // 
            // lbl_summary
            // 
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Location = new System.Drawing.Point(48, 54);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(177, 15);
            this.lbl_summary.TabIndex = 13;
            this.lbl_summary.Text = "Summary will be displayed here.";
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_complete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_complete.Location = new System.Drawing.Point(272, 194);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(93, 37);
            this.btn_complete.TabIndex = 12;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(173, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_user_registration_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_user_registration);
            this.Name = "frm_user_registration_application";
            this.Text = "User Registration Application";
            this.tc_user_registration.ResumeLayout(false);
            this.tp_profile_info.ResumeLayout(false);
            this.tp_profile_info.PerformLayout();
            this.tp_address_info.ResumeLayout(false);
            this.tp_address_info.PerformLayout();
            this.tp_summary.ResumeLayout(false);
            this.tp_summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tc_user_registration;
        private TabPage tp_profile_info;
        private Label lbl_email;
        private TextBox tb_email;
        private Label lbl_last_name;
        private TextBox tb_last_name;
        private Button btn_next_profile_info;
        private Label lbl_first_name;
        private TextBox tb_first_name;
        private TabPage tp_address_info;
        private TabPage tp_summary;
        private TextBox tb_address_line;
        private ComboBox cb_address_type;
        private Label lbl_address_type;
        private Button btn_next_address_info;
        private Button btn_back_address_info;
        private Button btn_complete;
        private Button button3;
        private Label lbl_address_line;
        private Label lbl_summary;
    }
}