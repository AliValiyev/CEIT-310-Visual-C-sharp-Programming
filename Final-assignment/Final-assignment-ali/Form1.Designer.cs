
namespace Final_assıgnment_ali
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
            this.ManageDepartments = new System.Windows.Forms.TabControl();
            this.tp_managedeps = new System.Windows.Forms.TabPage();
            this.btn_delete_course = new System.Windows.Forms.Button();
            this.btn_delete_dep = new System.Windows.Forms.Button();
            this.lstb_courses = new System.Windows.Forms.ListBox();
            this.lbl_dep = new System.Windows.Forms.Label();
            this.cmb_departmentforcourse = new System.Windows.Forms.ComboBox();
            this.tbx_capacity = new System.Windows.Forms.TextBox();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.tbx_type = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_create_course = new System.Windows.Forms.Button();
            this.tbx_coursecode = new System.Windows.Forms.TextBox();
            this.tbx_title = new System.Windows.Forms.TextBox();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lstb_deps = new System.Windows.Forms.ListBox();
            this.btn_createdep = new System.Windows.Forms.Button();
            this.tbx_abbreviation = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_abbreviation = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_confirmation_deps = new System.Windows.Forms.Label();
            this.lbl_confirmationmesseagforcourses = new System.Windows.Forms.Label();
            this.txb_filter_deps = new System.Windows.Forms.TextBox();
            this.txb_filter_courses = new System.Windows.Forms.TextBox();
            this.ManageDepartments.SuspendLayout();
            this.tp_managedeps.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageDepartments
            // 
            this.ManageDepartments.Controls.Add(this.tp_managedeps);
            this.ManageDepartments.Controls.Add(this.tabPage2);
            this.ManageDepartments.Location = new System.Drawing.Point(61, 4);
            this.ManageDepartments.Name = "ManageDepartments";
            this.ManageDepartments.SelectedIndex = 0;
            this.ManageDepartments.Size = new System.Drawing.Size(969, 480);
            this.ManageDepartments.TabIndex = 0;
            // 
            // tp_managedeps
            // 
            this.tp_managedeps.Controls.Add(this.txb_filter_courses);
            this.tp_managedeps.Controls.Add(this.txb_filter_deps);
            this.tp_managedeps.Controls.Add(this.lbl_confirmationmesseagforcourses);
            this.tp_managedeps.Controls.Add(this.lbl_confirmation_deps);
            this.tp_managedeps.Controls.Add(this.btn_delete_course);
            this.tp_managedeps.Controls.Add(this.btn_delete_dep);
            this.tp_managedeps.Controls.Add(this.lstb_courses);
            this.tp_managedeps.Controls.Add(this.lbl_dep);
            this.tp_managedeps.Controls.Add(this.cmb_departmentforcourse);
            this.tp_managedeps.Controls.Add(this.tbx_capacity);
            this.tp_managedeps.Controls.Add(this.lbl_capacity);
            this.tp_managedeps.Controls.Add(this.tbx_type);
            this.tp_managedeps.Controls.Add(this.lbl_type);
            this.tp_managedeps.Controls.Add(this.btn_create_course);
            this.tp_managedeps.Controls.Add(this.tbx_coursecode);
            this.tp_managedeps.Controls.Add(this.tbx_title);
            this.tp_managedeps.Controls.Add(this.lbl_coursecode);
            this.tp_managedeps.Controls.Add(this.lbl_title);
            this.tp_managedeps.Controls.Add(this.lstb_deps);
            this.tp_managedeps.Controls.Add(this.btn_createdep);
            this.tp_managedeps.Controls.Add(this.tbx_abbreviation);
            this.tp_managedeps.Controls.Add(this.tbx_name);
            this.tp_managedeps.Controls.Add(this.lbl_abbreviation);
            this.tp_managedeps.Controls.Add(this.lbl_name);
            this.tp_managedeps.Location = new System.Drawing.Point(4, 29);
            this.tp_managedeps.Name = "tp_managedeps";
            this.tp_managedeps.Padding = new System.Windows.Forms.Padding(3);
            this.tp_managedeps.Size = new System.Drawing.Size(961, 447);
            this.tp_managedeps.TabIndex = 0;
            this.tp_managedeps.Text = "Manage Departments";
            this.tp_managedeps.UseVisualStyleBackColor = true;
            this.tp_managedeps.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.Location = new System.Drawing.Point(725, 220);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(94, 29);
            this.btn_delete_course.TabIndex = 19;
            this.btn_delete_course.Text = "Delete";
            this.btn_delete_course.UseVisualStyleBackColor = true;
            this.btn_delete_course.Click += new System.EventHandler(this.btn_delete_course_Click);
            // 
            // btn_delete_dep
            // 
            this.btn_delete_dep.Location = new System.Drawing.Point(435, 220);
            this.btn_delete_dep.Name = "btn_delete_dep";
            this.btn_delete_dep.Size = new System.Drawing.Size(94, 29);
            this.btn_delete_dep.TabIndex = 18;
            this.btn_delete_dep.Text = "Delete";
            this.btn_delete_dep.UseVisualStyleBackColor = true;
            this.btn_delete_dep.Click += new System.EventHandler(this.btn_delete_dep_Click);
            // 
            // lstb_courses
            // 
            this.lstb_courses.FormattingEnabled = true;
            this.lstb_courses.ItemHeight = 20;
            this.lstb_courses.Location = new System.Drawing.Point(576, 11);
            this.lstb_courses.Name = "lstb_courses";
            this.lstb_courses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstb_courses.Size = new System.Drawing.Size(243, 164);
            this.lstb_courses.TabIndex = 17;
            // 
            // lbl_dep
            // 
            this.lbl_dep.AutoSize = true;
            this.lbl_dep.Location = new System.Drawing.Point(22, 363);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(89, 20);
            this.lbl_dep.TabIndex = 16;
            this.lbl_dep.Text = "Department";
            // 
            // cmb_departmentforcourse
            // 
            this.cmb_departmentforcourse.FormattingEnabled = true;
            this.cmb_departmentforcourse.Location = new System.Drawing.Point(126, 360);
            this.cmb_departmentforcourse.Name = "cmb_departmentforcourse";
            this.cmb_departmentforcourse.Size = new System.Drawing.Size(151, 28);
            this.cmb_departmentforcourse.TabIndex = 15;
            // 
            // tbx_capacity
            // 
            this.tbx_capacity.Location = new System.Drawing.Point(126, 316);
            this.tbx_capacity.Name = "tbx_capacity";
            this.tbx_capacity.Size = new System.Drawing.Size(125, 27);
            this.tbx_capacity.TabIndex = 14;
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(22, 316);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(66, 20);
            this.lbl_capacity.TabIndex = 13;
            this.lbl_capacity.Text = "Capacity";
            // 
            // tbx_type
            // 
            this.tbx_type.Location = new System.Drawing.Point(126, 271);
            this.tbx_type.Name = "tbx_type";
            this.tbx_type.Size = new System.Drawing.Size(125, 27);
            this.tbx_type.TabIndex = 12;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(22, 271);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 20);
            this.lbl_type.TabIndex = 11;
            this.lbl_type.Text = "Type";
            // 
            // btn_create_course
            // 
            this.btn_create_course.Location = new System.Drawing.Point(126, 394);
            this.btn_create_course.Name = "btn_create_course";
            this.btn_create_course.Size = new System.Drawing.Size(94, 29);
            this.btn_create_course.TabIndex = 10;
            this.btn_create_course.Text = "Create";
            this.btn_create_course.UseVisualStyleBackColor = true;
            this.btn_create_course.Click += new System.EventHandler(this.btn_create_course_Click);
            // 
            // tbx_coursecode
            // 
            this.tbx_coursecode.Location = new System.Drawing.Point(126, 229);
            this.tbx_coursecode.Name = "tbx_coursecode";
            this.tbx_coursecode.Size = new System.Drawing.Size(125, 27);
            this.tbx_coursecode.TabIndex = 9;
            // 
            // tbx_title
            // 
            this.tbx_title.Location = new System.Drawing.Point(126, 188);
            this.tbx_title.Name = "tbx_title";
            this.tbx_title.Size = new System.Drawing.Size(125, 27);
            this.tbx_title.TabIndex = 8;
            this.tbx_title.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Location = new System.Drawing.Point(22, 229);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(89, 20);
            this.lbl_coursecode.TabIndex = 7;
            this.lbl_coursecode.Text = "CourseCode";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(22, 191);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(41, 20);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Title:";
            // 
            // lstb_deps
            // 
            this.lstb_deps.FormattingEnabled = true;
            this.lstb_deps.ItemHeight = 20;
            this.lstb_deps.Location = new System.Drawing.Point(295, 11);
            this.lstb_deps.Name = "lstb_deps";
            this.lstb_deps.Size = new System.Drawing.Size(243, 164);
            this.lstb_deps.TabIndex = 5;
            this.lstb_deps.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_createdep
            // 
            this.btn_createdep.Location = new System.Drawing.Point(126, 131);
            this.btn_createdep.Name = "btn_createdep";
            this.btn_createdep.Size = new System.Drawing.Size(94, 29);
            this.btn_createdep.TabIndex = 4;
            this.btn_createdep.Text = "Create";
            this.btn_createdep.UseVisualStyleBackColor = true;
            this.btn_createdep.Click += new System.EventHandler(this.btn_createdep_Click);
            // 
            // tbx_abbreviation
            // 
            this.tbx_abbreviation.Location = new System.Drawing.Point(126, 88);
            this.tbx_abbreviation.Name = "tbx_abbreviation";
            this.tbx_abbreviation.Size = new System.Drawing.Size(125, 27);
            this.tbx_abbreviation.TabIndex = 3;
            this.tbx_abbreviation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(126, 47);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(125, 27);
            this.tbx_name.TabIndex = 2;
            // 
            // lbl_abbreviation
            // 
            this.lbl_abbreviation.AutoSize = true;
            this.lbl_abbreviation.Location = new System.Drawing.Point(22, 88);
            this.lbl_abbreviation.Name = "lbl_abbreviation";
            this.lbl_abbreviation.Size = new System.Drawing.Size(98, 20);
            this.lbl_abbreviation.TabIndex = 1;
            this.lbl_abbreviation.Text = "Abbreviation:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(22, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_confirmation_deps
            // 
            this.lbl_confirmation_deps.AutoSize = true;
            this.lbl_confirmation_deps.Location = new System.Drawing.Point(435, 259);
            this.lbl_confirmation_deps.Name = "lbl_confirmation_deps";
            this.lbl_confirmation_deps.Size = new System.Drawing.Size(269, 20);
            this.lbl_confirmation_deps.TabIndex = 20;
            this.lbl_confirmation_deps.Text = "Confirmation message for departments";
            // 
            // lbl_confirmationmesseagforcourses
            // 
            this.lbl_confirmationmesseagforcourses.AutoSize = true;
            this.lbl_confirmationmesseagforcourses.Location = new System.Drawing.Point(435, 295);
            this.lbl_confirmationmesseagforcourses.Name = "lbl_confirmationmesseagforcourses";
            this.lbl_confirmationmesseagforcourses.Size = new System.Drawing.Size(234, 20);
            this.lbl_confirmationmesseagforcourses.TabIndex = 21;
            this.lbl_confirmationmesseagforcourses.Text = "Confirmation message for courses";
            // 
            // txb_filter_deps
            // 
            this.txb_filter_deps.Location = new System.Drawing.Point(318, 181);
            this.txb_filter_deps.Name = "txb_filter_deps";
            this.txb_filter_deps.Size = new System.Drawing.Size(159, 27);
            this.txb_filter_deps.TabIndex = 22;
            this.txb_filter_deps.TextChanged += new System.EventHandler(this.txb_filter_deps_TextChanged);
            // 
            // txb_filter_courses
            // 
            this.txb_filter_courses.Location = new System.Drawing.Point(590, 181);
            this.txb_filter_courses.Name = "txb_filter_courses";
            this.txb_filter_courses.Size = new System.Drawing.Size(159, 27);
            this.txb_filter_courses.TabIndex = 23;
            this.txb_filter_courses.TextChanged += new System.EventHandler(this.txb_filter_courses_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 542);
            this.Controls.Add(this.ManageDepartments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ManageDepartments.ResumeLayout(false);
            this.tp_managedeps.ResumeLayout(false);
            this.tp_managedeps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManageDepartments;
        private System.Windows.Forms.TabPage tp_managedeps;
        private System.Windows.Forms.Label lbl_abbreviation;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbx_abbreviation;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Button btn_createdep;
        private System.Windows.Forms.Button btn_create_course;
        private System.Windows.Forms.TextBox tbx_coursecode;
        private System.Windows.Forms.TextBox tbx_title;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lstb_deps;
        private System.Windows.Forms.Label lbl_dep;
        private System.Windows.Forms.ComboBox cmb_departmentforcourse;
        private System.Windows.Forms.TextBox tbx_capacity;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.TextBox tbx_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_delete_course;
        private System.Windows.Forms.Button btn_delete_dep;
        private System.Windows.Forms.ListBox lstb_courses;
        private System.Windows.Forms.Label lbl_confirmation_deps;
        private System.Windows.Forms.Label lbl_confirmationmesseagforcourses;
        private System.Windows.Forms.TextBox txb_filter_courses;
        private System.Windows.Forms.TextBox txb_filter_deps;
    }
}

