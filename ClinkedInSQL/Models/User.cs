using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedInSQL.Models
{
    public class User
    {
        public User(int id, string name, DateTime? releaseDate, bool isPrisoner, int? age)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            IsPrisoner = isPrisoner;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool IsPrisoner { get; set; }
        public int? Age { get; set; }
    }
}
