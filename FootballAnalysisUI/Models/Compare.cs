namespace FootballAnalysisUI.Models
{
    public class compare  //karşılaştırma
    {
        public string TeamOneName { get; set; }
        public int TeamOneGoalAll { get; set; }
        public int TeamOneGoalinHome { get; set; }
        public int TeamOneGoalinAway { get; set; }
        public int TeamOneWinAll { get; set; }
        public int TeamOneWininHome { get; set; }
        public int TeamOneWininAway { get; set; }
        public string TeamTwoName { get; set; }
        public int TeamTwoGoalAll { get; set; }
        public int TeamTwoGoalinHome { get; set; }
        public int TeamTwoGoalinAway { get; set; }
        public int TeamTwoWinAll { get; set; }
        public int TeamTwoWininHome { get; set; }
        public int TeamTwoWininAway { get; set; }
        public int DrawCount { get; set; }
        public int MatchCount { get; set; }
        public int GoalAll { get; set; }
        public int TeamOneURLNumber { get; set; }
        public int TeamTwoURLNumber { get; set; }
        public int TeamOneHomeDraw { get; set; }
        public int TeamTwoHomeDraw { get; set; }
        public int TeamOneID { get; set; }
        public int TeamTwoID { get; set; }
     
        public Compare()
        {
            TeamOneGoalAll = 0;
            TeamOneGoalinHome = 0;
            TeamOneGoalinAway = 0;
            TeamOneWinAll = 0;
            TeamOneWininHome = 0;
            TeamOneWininAway = 0;
            TeamTwoGoalAll = 0;
            TeamTwoGoalinHome = 0;
            TeamTwoGoalinAway = 0;
            TeamTwoWinAll = 0;
            TeamTwoWininHome = 0;
            TeamTwoWininAway = 0;
            DrawCount = 0;
            MatchCount = 0;
            GoalAll = 0;
            TeamOneHomeDraw = 0;
            TeamTwoHomeDraw = 0;
        }

        float goalCompareAll()
        {
            int goalAll = TeamOneGoalAll + TeamTwoGoalAll;
            return TeamOneGoalAll / goalAll;
        }

        float goalCompareinHome()
        {
            int goalinHome = TeamOneGoalinHome + TeamTwoGoalinHome;
            return TeamOneGoalinHome / goalinHome;
        }

        float goalCompareinAway()
        {
            int goalinAway = TeamOneGoalinAway + TeamTwoGoalinAway;
            return TeamOneGoalinAway / goalinAway;
        }

        float winAll()
        {
            int winAll = TeamOneWinAll + TeamTwoWinAll;
            return TeamOneWinAll / winAll;
        }

        float wininHome()
        {
            int winHome = TeamOneWininHome + TeamTwoWininHome;
            return TeamOneWininHome / winHome;
        }

        float wininAway()
        {
            int awayWin = TeamOneWininAway + TeamTwoWininAway;
            return TeamOneWininAway / awayWin;
        }

        float draw()
        {
            return DrawCount / MatchCount;
        }

        float winTeamOne()
        {
            return TeamOneWinAll / MatchCount;
        }

        float winTeamTwo()
        {
            return TeamTwoWinAll / MatchCount;
        }

        public string TeamOneHomeInfo()
        {
            if ((float)TeamOneWininHome / (TeamOneHomeDraw + TeamTwoWininAway + TeamOneWininHome) > 0.7)
            {
                return TeamOneName + " genelde evinde kazanıyor.";
            }
            else
            {
                return null;
            }
        }
        public string TeamOneAwayInfo()
        {
            if ((float)TeamOneWininAway / (TeamTwoHomeDraw + TeamOneWininAway + TeamTwoWininHome) > 0.7)
            {
                return TeamOneName + " genelde deplasmanda kazanıyor.";
            }
            else
            {
                return null;
            }
        }

        public string TeamTwoHomeInfo()
        {
            if ((float)TeamTwoWininHome / (TeamTwoHomeDraw + TeamOneWininAway + TeamTwoWininHome) > 0.7)
            {
                return TeamTwoName + " genelde evinde kazanıyor.";
            }
            else
            {
                return null;
            }
        }

        public string TeamTwoAwayInfo()
        {
            if ((float)TeamTwoWininAway / (TeamOneHomeDraw + TeamTwoWininAway + TeamOneWininHome) > 0.7)
            {
                return TeamTwoName + " genelde deplasmanda kazanıyor.";
            }
            else
            {
                return null;
            }
        }
        public string TeamOneHomeGoalInfo()
        {
            if ((float)TeamOneGoalinHome / (TeamOneGoalinHome + TeamTwoGoalinAway) > 0.7)
            {
                return TeamOneName + " evinde gollerin çoğunu atıyor.";
            }
            else
            {
                return null;
            }
        }
        public string TeamTwoHomeGoalInfo()
        {
            if ((float)TeamTwoGoalinHome / (TeamOneGoalinAway + TeamTwoGoalinHome) > 0.7)
            {
                return TeamTwoName + " evinde gollerin çoğunu atıyor.";
            }
            else
            {
                return null;
            }
        }
        public string TeamOneAwayGoalInfo()
        {
            if ((float)TeamOneGoalinAway / (TeamOneGoalinAway + TeamTwoGoalinHome) > 0.7)
            {
                return TeamOneName + " deplasmanda gollerin çoğunu atıyor.";
            }
            else
            {
                return null;
            }
        }
        public string TeamTwoAwayGoalInfo()
        {
            if ((float)TeamTwoGoalinAway / (TeamOneGoalinHome + TeamTwoGoalinAway) > 0.7)
            {
                return TeamTwoName + " deplasmanda gollerin çoğunu atıyor.";
            }
            else
            {
                return null;
            }
        }

    }
}
