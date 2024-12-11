using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class CustomerCreditBureauReportingYearlyHistory
    {
        public string CbeCustomerId { get; set; } = null!;
        public short Score { get; set; }
        public short Year { get; set; }

        public virtual CbeCustomer CbeCustomer { get; set; } = null!;
    }
}
