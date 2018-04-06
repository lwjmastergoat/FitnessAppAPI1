using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessAppAPI1
{
    public class Sessiondetails
    {
        public Session session { get; set; }
        public List<SessionItemDetails> sessionItems { get; set; }

    }
}