using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.BLL.DTO
{
    public class BattleDTO
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public DateTime Date { get; set; }
        public int AmoutOfRounds { get; set; }
        public int ReferrePoints { get; set; }
    }
}
