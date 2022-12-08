using m9-lab-ali.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m9-lab-ali
{
    public partial class frm_teamBase : Form
    {
        public frm_teamBase()
        {
            InitializeComponent();
        }
        BindingList<Team> teams = new BindingList<Team>();
        int idControl = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 400;
            lst_teams.DataSource = teams;
            lst_teams.DisplayMember = "DisplayText";
            lst_teams.ValueMember = "Id";
        }

        private void ResetForm()
        {
            txt_name.Text = "";
            txt_league.Text = "";
            txt_wins.Text = "";
            txt_defeats.Text = "";
            txt_draw.Text = "";
            txt_scoresAchieved.Text = "";
            txt_scoresConceded.Text = "";
            txt_fauls.Text = "";
            txt_rebounds.Text = "";
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Width = 760;
        }

        private void CommonProperties(Team team)
        {
            team.Id = idControl;
            idControl++;
            team.Name = txt_name.Text;
            team.League = txt_league.Text;
            team.Wins = int.Parse(txt_wins.Text);
            team.Defeats = int.Parse(txt_defeats.Text);
            team.ScoresAchieved = int.Parse(txt_scoresAchieved.Text);
            team.ScoresConceded = int.Parse(txt_scoresConceded.Text);
        }


        private void btn_addFootballTeam_Click(object sender, EventArgs e)
        {
            FootballTeam footballTeam = new FootballTeam();
            CommonProperties(footballTeam);
            footballTeam.Draws = int.Parse(txt_draw.Text);
            teams.Add(footballTeam);
            ResetForm();
            tabControl_adv.SelectedTab = tab_list;
        }

        private void btn_addTeamBasketball_Click(object sender, EventArgs e)
        {
            BasketballTeam basketballTeam = new BasketballTeam();
            CommonProperties(basketballTeam);
            basketballTeam.TotalRebounds = int.Parse(txt_rebounds.Text);
            basketballTeam.TotalFauls = int.Parse(txt_fauls.Text);
            teams.Add(basketballTeam);
            ResetForm();
            tabControl_adv.SelectedTab = tab_list;
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.Width = 400;
        }

        private void lst_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teamId = (int)lst_teams.SelectedValue;
            Team selectedTeam = teams.Single(c => c.Id == teamId);
            int matches = selectedTeam.CalculateMatchsPlayed();
            int points = selectedTeam.CalculatePoints();
            lbl_matchesPlayed.Text = "Total of " + matches.ToString() + " matches played.";
            lbl_points.Text = "Total of " + points.ToString() + " points earned.";
        }
    }
}
