using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedInSQL.Models
{
    public class UserInterest
    {
        public UserInterest(string name, string interest)
        {
            Name = name;
            Interest = interest;
        }

        public string Name { get; set; }
        public string Interest { get; set; }
    }
}
