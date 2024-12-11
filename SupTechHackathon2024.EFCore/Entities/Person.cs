using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Person
    {
        public Person()
        {
            CbeCustomers = new HashSet<CbeCustomer>();
            Smes = new HashSet<Sme>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public short MaritalStatusId { get; set; }
        public short EmploymentStatusId { get; set; }
        public string IdDocumentNumber { get; set; } = null!;
        public short OfficialIdDocumentTypeId { get; set; }
        public short? EducationLevelId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? AlternativePhoneNumber { get; set; }
        public string? Email { get; set; }
        public string Occupation { get; set; } = null!;

        public virtual EducationLevel? EducationLevel { get; set; }
        public virtual EmploymentStatus EmploymentStatus { get; set; } = null!;
        public virtual MaritalStatus MaritalStatus { get; set; } = null!;
        public virtual OfficialIdDocumentType OfficialIdDocumentType { get; set; } = null!;
        public virtual ICollection<CbeCustomer> CbeCustomers { get; set; }
        public virtual ICollection<Sme> Smes { get; set; }
    }
}
