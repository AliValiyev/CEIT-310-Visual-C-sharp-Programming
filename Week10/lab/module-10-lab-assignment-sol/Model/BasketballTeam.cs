using System;
using System.Collections.Generic;
using System.Text;

namespace m9-lab-ali.Model
{
    internal class BasketballTeam : Team
    {
        public int TotalFauls { get; set; }
        public int TotalRebounds { get; set; }
        public override string DisplayText
        {
            get { return "Basketball, " + League + ": " + Name; }
        }
        public override int CalculateMatchsPlayed()
        {
            return Wins + Defeats;
        }
        public override int CalculatePoints()
        {
            return Wins * 2 + Defeats;
        }
    }
}
