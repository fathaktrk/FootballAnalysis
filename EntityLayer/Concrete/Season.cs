using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Season
    {
        public int ID { get; set; }
        public int SeasonYear { get; set; }
        public string Champion { get; set; }
        public string GoalKing { get; set; }
        public int GoalKingScore { get; set; }
        public ICollection<MatchScore> MatchScore { get; set; }


    }
}
