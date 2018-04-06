using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessAppAPI1
{
    public class FullProgram
    {
        public Program program { get; set; }
        public List<Sessiondetails> sessionDetails { get; set; }
    }
}