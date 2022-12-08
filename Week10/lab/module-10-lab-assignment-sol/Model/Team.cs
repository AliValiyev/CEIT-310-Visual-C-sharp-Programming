using System;
using System.Collections.Generic;
using System.Text;

namespace m9-lab-ali.Model
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string League { get; set; }
        public int Wins { get; set; }
        public virtual string DisplayText 
        { 
            get { return ""; }
        }
        public int Defeats { get; set; }
        public int ScoresAchieved { get; set; }
        public int ScoresConceded { get; set; }
        public int Average { get { return ScoresAchieved - ScoresConceded; }
        }

        public virtual int CalculateMatchsPlayed()
        {
            return 0;
        }
        public virtual int CalculatePoints()
        {
            return 0;
        }
    }
}
