using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MatchScore
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string OpponentName { get; set; }
        public int HomeScore { get; set; }
        public int OpponentScore { get; set; }
        public int Season_ID { get; set; }
    }
}
