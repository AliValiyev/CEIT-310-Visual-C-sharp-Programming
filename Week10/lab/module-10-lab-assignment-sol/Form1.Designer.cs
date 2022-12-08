namespace m9-lab-ali
{
    partial class frm_teamBase
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
            this.gBox_team = new System.Windows.Forms.GroupBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.txt_scoresAchieved = new System.Windows.Forms.TextBox();
            this.lbl_scoresAchieved = new System.Windows.Forms.Label();
            this.txt_scoresConceded = new System.Windows.Forms.TextBox();
            this.lbl_scoresConceded = new System.Windows.Forms.Label();
            this.txt_defeats = new System.Windows.Forms.TextBox();
            this.lbl_defeats = new System.Windows.Forms.Label();
            this.txt_wins = new System.Windows.Forms.TextBox();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.txt_league = new System.Windows.Forms.TextBox();
            this.lbl_league = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tabControl_adv = new System.Windows.Forms.TabControl();
            this.tab_football = new System.Windows.Forms.TabPage();
            this.btn_addFootballTeam = new System.Windows.Forms.Button();
            this.lbl_draw = new System.Windows.Forms.Label();
            this.txt_draw = new System.Windows.Forms.TextBox();
            this.tab_basketball = new System.Windows.Forms.TabPage();
            this.btn_addTeamBasketball = new System.Windows.Forms.Button();
            this.txt_rebounds = new System.Windows.Forms.TextBox();
            this.lbl_fauls = new System.Windows.Forms.Label();
            this.lbl_rebounds = new System.Windows.Forms.Label();
            this.txt_fauls = new System.Windows.Forms.TextBox();
            this.tab_list = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_points = new System.Windows.Forms.Label();
            this.lbl_matchesPlayed = new System.Windows.Forms.Label();
            this.lst_teams = new System.Windows.Forms.ListBox();
            this.gBox_team.SuspendLayout();
            this.tabControl_adv.SuspendLayout();
            this.tab_football.SuspendLayout();
            this.tab_basketball.SuspendLayout();
            this.tab_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_team
            // 
            this.gBox_team.Controls.Add(this.btn_continue);
            this.gBox_team.Controls.Add(this.txt_scoresAchieved);
            this.gBox_team.Controls.Add(this.lbl_scoresAchieved);
            this.gBox_team.Controls.Add(this.txt_scoresConceded);
            this.gBox_team.Controls.Add(this.lbl_scoresConceded);
            this.gBox_team.Controls.Add(this.txt_defeats);
            this.gBox_team.Controls.Add(this.lbl_defeats);
            this.gBox_team.Controls.Add(this.txt_wins);
            this.gBox_team.Controls.Add(this.lbl_wins);
            this.gBox_team.Controls.Add(this.txt_league);
            this.gBox_team.Controls.Add(this.lbl_league);
            this.gBox_team.Controls.Add(this.txt_name);
            this.gBox_team.Controls.Add(this.lbl_name);
            this.gBox_team.Location = new System.Drawing.Point(43, 31);
            this.gBox_team.Name = "gBox_team";
            this.gBox_team.Size = new System.Drawing.Size(301, 440);
            this.gBox_team.TabIndex = 0;
            this.gBox_team.TabStop = false;
            this.gBox_team.Text = "Team";
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(174, 383);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(94, 29);
            this.btn_continue.TabIndex = 0;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // txt_scoresAchieved
            // 
            this.txt_scoresAchieved.Location = new System.Drawing.Point(21, 273);
            this.txt_scoresAchieved.Name = "txt_scoresAchieved";
            this.txt_scoresAchieved.Size = new System.Drawing.Size(218, 27);
            this.txt_scoresAchieved.TabIndex = 11;
            // 
            // lbl_scoresAchieved
            // 
            this.lbl_scoresAchieved.AutoSize = true;
            this.lbl_scoresAchieved.Location = new System.Drawing.Point(21, 250);
            this.lbl_scoresAchieved.Name = "lbl_scoresAchieved";
            this.lbl_scoresAchieved.Size = new System.Drawing.Size(120, 20);
            this.lbl_scoresAchieved.TabIndex = 12;
            this.lbl_scoresAchieved.Text = "Scores Achieved:";
            // 
            // txt_scoresConceded
            // 
            this.txt_scoresConceded.Location = new System.Drawing.Point(21, 326);
            this.txt_scoresConceded.Name = "txt_scoresConceded";
            this.txt_scoresConceded.Size = new System.Drawing.Size(218, 27);
            this.txt_scoresConceded.TabIndex = 9;
            // 
            // lbl_scoresConceded
            // 
            this.lbl_scoresConceded.AutoSize = true;
            this.lbl_scoresConceded.Location = new System.Drawing.Point(21, 303);
            this.lbl_scoresConceded.Name = "lbl_scoresConceded";
            this.lbl_scoresConceded.Size = new System.Drawing.Size(126, 20);
            this.lbl_scoresConceded.TabIndex = 10;
            this.lbl_scoresConceded.Text = "Scores Conceded:";
            // 
            // txt_defeats
            // 
            this.txt_defeats.Location = new System.Drawing.Point(21, 220);
            this.txt_defeats.Name = "txt_defeats";
            this.txt_defeats.Size = new System.Drawing.Size(218, 27);
            this.txt_defeats.TabIndex = 7;
            // 
            // lbl_defeats
            // 
            this.lbl_defeats.AutoSize = true;
            this.lbl_defeats.Location = new System.Drawing.Point(21, 197);
            this.lbl_defeats.Name = "lbl_defeats";
            this.lbl_defeats.Size = new System.Drawing.Size(63, 20);
            this.lbl_defeats.TabIndex = 8;
            this.lbl_defeats.Text = "Defeats:";
            // 
            // txt_wins
            // 
            this.txt_wins.Location = new System.Drawing.Point(21, 170);
            this.txt_wins.Name = "txt_wins";
            this.txt_wins.Size = new System.Drawing.Size(218, 27);
            this.txt_wins.TabIndex = 5;
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.Location = new System.Drawing.Point(21, 147);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(44, 20);
            this.lbl_wins.TabIndex = 6;
            this.lbl_wins.Text = "Wins:";
            // 
            // txt_league
            // 
            this.txt_league.Location = new System.Drawing.Point(21, 110);
            this.txt_league.Name = "txt_league";
            this.txt_league.Size = new System.Drawing.Size(218, 27);
            this.txt_league.TabIndex = 3;
            // 
            // lbl_league
            // 
            this.lbl_league.AutoSize = true;
            this.lbl_league.Location = new System.Drawing.Point(21, 87);
            this.lbl_league.Name = "lbl_league";
            this.lbl_league.Size = new System.Drawing.Size(60, 20);
            this.lbl_league.TabIndex = 4;
            this.lbl_league.Text = "League:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(21, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(218, 27);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(21, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(92, 20);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Team Name:";
            // 
            // tabControl_adv
            // 
            this.tabControl_adv.Controls.Add(this.tab_football);
            this.tabControl_adv.Controls.Add(this.tab_basketball);
            this.tabControl_adv.Controls.Add(this.tab_list);
            this.tabControl_adv.Location = new System.Drawing.Point(397, 31);
            this.tabControl_adv.Name = "tabControl_adv";
            this.tabControl_adv.SelectedIndex = 0;
            this.tabControl_adv.Size = new System.Drawing.Size(306, 440);
            this.tabControl_adv.TabIndex = 1;
            // 
            // tab_football
            // 
            this.tab_football.Controls.Add(this.btn_addFootballTeam);
            this.tab_football.Controls.Add(this.lbl_draw);
            this.tab_football.Controls.Add(this.txt_draw);
            this.tab_football.Location = new System.Drawing.Point(4, 29);
            this.tab_football.Name = "tab_football";
            this.tab_football.Padding = new System.Windows.Forms.Padding(3);
            this.tab_football.Size = new System.Drawing.Size(298, 407);
            this.tab_football.TabIndex = 0;
            this.tab_football.Text = "Football";
            this.tab_football.UseVisualStyleBackColor = true;
            // 
            // btn_addFootballTeam
            // 
            this.btn_addFootballTeam.Location = new System.Drawing.Point(181, 133);
            this.btn_addFootballTeam.Name = "btn_addFootballTeam";
            this.btn_addFootballTeam.Size = new System.Drawing.Size(94, 29);
            this.btn_addFootballTeam.TabIndex = 15;
            this.btn_addFootballTeam.Text = "Add Team";
            this.btn_addFootballTeam.UseVisualStyleBackColor = true;
            this.btn_addFootballTeam.Click += new System.EventHandler(this.btn_addFootballTeam_Click);
            // 
            // lbl_draw
            // 
            this.lbl_draw.AutoSize = true;
            this.lbl_draw.Location = new System.Drawing.Point(21, 26);
            this.lbl_draw.Name = "lbl_draw";
            this.lbl_draw.Size = new System.Drawing.Size(47, 20);
            this.lbl_draw.TabIndex = 14;
            this.lbl_draw.Text = "Draw:";
            // 
            // txt_draw
            // 
            this.txt_draw.Location = new System.Drawing.Point(21, 49);
            this.txt_draw.Name = "txt_draw";
            this.txt_draw.Size = new System.Drawing.Size(218, 27);
            this.txt_draw.TabIndex = 13;
            // 
            // tab_basketball
            // 
            this.tab_basketball.Controls.Add(this.btn_addTeamBasketball);
            this.tab_basketball.Controls.Add(this.txt_rebounds);
            this.tab_basketball.Controls.Add(this.lbl_fauls);
            this.tab_basketball.Controls.Add(this.lbl_rebounds);
            this.tab_basketball.Controls.Add(this.txt_fauls);
            this.tab_basketball.Location = new System.Drawing.Point(4, 29);
            this.tab_basketball.Name = "tab_basketball";
            this.tab_basketball.Padding = new System.Windows.Forms.Padding(3);
            this.tab_basketball.Size = new System.Drawing.Size(298, 407);
            this.tab_basketball.TabIndex = 1;
            this.tab_basketball.Text = "Basketball";
            this.tab_basketball.UseVisualStyleBackColor = true;
            // 
            // btn_addTeamBasketball
            // 
            this.btn_addTeamBasketball.Location = new System.Drawing.Point(177, 163);
            this.btn_addTeamBasketball.Name = "btn_addTeamBasketball";
            this.btn_addTeamBasketball.Size = new System.Drawing.Size(94, 29);
            this.btn_addTeamBasketball.TabIndex = 16;
            this.btn_addTeamBasketball.Text = "Add Team";
            this.btn_addTeamBasketball.UseVisualStyleBackColor = true;
            this.btn_addTeamBasketball.Click += new System.EventHandler(this.btn_addTeamBasketball_Click);
            // 
            // txt_rebounds
            // 
            this.txt_rebounds.Location = new System.Drawing.Point(26, 104);
            this.txt_rebounds.Name = "txt_rebounds";
            this.txt_rebounds.Size = new System.Drawing.Size(218, 27);
            this.txt_rebounds.TabIndex = 15;
            // 
            // lbl_fauls
            // 
            this.lbl_fauls.AutoSize = true;
            this.lbl_fauls.Location = new System.Drawing.Point(26, 23);
            this.lbl_fauls.Name = "lbl_fauls";
            this.lbl_fauls.Size = new System.Drawing.Size(44, 20);
            this.lbl_fauls.TabIndex = 14;
            this.lbl_fauls.Text = "Fauls:";
            // 
            // lbl_rebounds
            // 
            this.lbl_rebounds.AutoSize = true;
            this.lbl_rebounds.Location = new System.Drawing.Point(26, 81);
            this.lbl_rebounds.Name = "lbl_rebounds";
            this.lbl_rebounds.Size = new System.Drawing.Size(78, 20);
            this.lbl_rebounds.TabIndex = 16;
            this.lbl_rebounds.Text = "Rebounds:";
            // 
            // txt_fauls
            // 
            this.txt_fauls.Location = new System.Drawing.Point(26, 46);
            this.txt_fauls.Name = "txt_fauls";
            this.txt_fauls.Size = new System.Drawing.Size(218, 27);
            this.txt_fauls.TabIndex = 13;
            // 
            // tab_list
            // 
            this.tab_list.Controls.Add(this.btn_reset);
            this.tab_list.Controls.Add(this.lbl_points);
            this.tab_list.Controls.Add(this.lbl_matchesPlayed);
            this.tab_list.Controls.Add(this.lst_teams);
            this.tab_list.Location = new System.Drawing.Point(4, 29);
            this.tab_list.Name = "tab_list";
            this.tab_list.Size = new System.Drawing.Size(298, 407);
            this.tab_list.TabIndex = 2;
            this.tab_list.Text = "Team List";
            this.tab_list.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(168, 354);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(23, 313);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(200, 20);
            this.lbl_points.TabIndex = 2;
            this.lbl_points.Text = "Points will be displayed here.";
            // 
            // lbl_matchesPlayed
            // 
            this.lbl_matchesPlayed.AutoSize = true;
            this.lbl_matchesPlayed.Location = new System.Drawing.Point(23, 271);
            this.lbl_matchesPlayed.Name = "lbl_matchesPlayed";
            this.lbl_matchesPlayed.Size = new System.Drawing.Size(265, 20);
            this.lbl_matchesPlayed.TabIndex = 1;
            this.lbl_matchesPlayed.Text = "Matches played will be displayed here.";
            // 
            // lst_teams
            // 
            this.lst_teams.FormattingEnabled = true;
            this.lst_teams.ItemHeight = 20;
            this.lst_teams.Location = new System.Drawing.Point(23, 28);
            this.lst_teams.Name = "lst_teams";
            this.lst_teams.Size = new System.Drawing.Size(253, 204);
            this.lst_teams.TabIndex = 0;
            this.lst_teams.SelectedIndexChanged += new System.EventHandler(this.lst_teams_SelectedIndexChanged);
            // 
            // frm_teamBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 506);
            this.Controls.Add(this.tabControl_adv);
            this.Controls.Add(this.gBox_team);
            this.Name = "frm_teamBase";
            this.Text = "Team Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox_team.ResumeLayout(false);
            this.gBox_team.PerformLayout();
            this.tabControl_adv.ResumeLayout(false);
            this.tab_football.ResumeLayout(false);
            this.tab_football.PerformLayout();
            this.tab_basketball.ResumeLayout(false);
            this.tab_basketball.PerformLayout();
            this.tab_list.ResumeLayout(false);
            this.tab_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_team;
        private System.Windows.Forms.TabControl tabControl_adv;
        private System.Windows.Forms.TabPage tab_football;
        private System.Windows.Forms.TabPage tab_basketball;
        private System.Windows.Forms.TabPage tab_list;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox txt_scoresAchieved;
        private System.Windows.Forms.Label lbl_scoresAchieved;
        private System.Windows.Forms.TextBox txt_scoresConceded;
        private System.Windows.Forms.Label lbl_scoresConceded;
        private System.Windows.Forms.TextBox txt_defeats;
        private System.Windows.Forms.Label lbl_defeats;
        private System.Windows.Forms.TextBox txt_wins;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.TextBox txt_league;
        private System.Windows.Forms.Label lbl_league;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_addFootballTeam;
        private System.Windows.Forms.Label lbl_draw;
        private System.Windows.Forms.TextBox txt_draw;
        private System.Windows.Forms.Button btn_addTeamBasketball;
        private System.Windows.Forms.TextBox txt_rebounds;
        private System.Windows.Forms.Label lbl_fauls;
        private System.Windows.Forms.Label lbl_rebounds;
        private System.Windows.Forms.TextBox txt_fauls;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Label lbl_matchesPlayed;
        private System.Windows.Forms.ListBox lst_teams;
        private System.Windows.Forms.Button btn_reset;
    }
}
