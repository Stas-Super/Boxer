using Boxer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boxer.Models
{
    public class Battle : BaseEntity<int>
    {

        public string First { get; set; }
        public string Second { get; set; }
        public DateTime Date { get; set; }
        public int AmoutOfRounds { get; set; }
        public int ReferrePoints { get; set; }
    }
}