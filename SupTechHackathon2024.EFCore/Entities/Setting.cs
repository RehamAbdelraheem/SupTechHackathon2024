using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public short DeptBurdenRatio { get; set; }
        public short MinLoanAllowedRiskRateInclusive { get; set; }
        public short MaxLoanAllowedRiskRateInclusive { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsDefault { get; set; }
    }
}
