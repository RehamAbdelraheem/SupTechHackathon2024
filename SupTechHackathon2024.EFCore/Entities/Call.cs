using SupTechHackathon2024.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupTechHackathon2024.EFCore.Models;

public partial class Call :EntityBase
{
    public long Id { get; set; }
    public string CbeCustomerId { get; set; } = null!;
    public int BankId { get; set; }
    public int BankBranchId { get; set; }
    public string Transcript { get; set; } = null!;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool? IsAiAnalysisFailed { get; set; } // Nullable || true
    public bool? IsMisSellingDetected { get; set; }
    public int? MisSellingCategoryId { get; set; }
    public int? FinancialServiceId { get; set; }

    public virtual Bank Bank { get; set; } = null!;
    public virtual BankBranch Branch { get; set; } = null!;
    public virtual CbeCustomer CbeCustomer { get; set; } = null!;
    public virtual FinancialService? FinancialService { get; set; }
    public virtual MisSellingCategory? MisSellingCategory { get; set; }
}
