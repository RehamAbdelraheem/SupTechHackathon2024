using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            People = new HashSet<Person>();
        }

        public short Id { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public virtual ICollection<Person> People { get; set; }
    }
}
