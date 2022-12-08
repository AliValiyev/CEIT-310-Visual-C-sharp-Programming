using System;
using System.Collections.Generic;
using System.Text;

namespace m9-lab-ali.Model
{
    internal class FootballTeam : Team
    {
        public int Draws { get; set; }

        public override string DisplayText
        {
            get { return "Football, " + League + ": " + Name; }
        }

        public override int CalculateMatchsPlayed()
        {
            return Wins + Defeats + Draws;
        }
        public override int CalculatePoints()
        {
            return Wins * 3 + Draws;
        }
    }
}
