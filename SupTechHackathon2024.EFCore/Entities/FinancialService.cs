using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models;

public partial class FinancialService
{
    public FinancialService()
    {
        Calls = new HashSet<Call>();
    }

    public int Id { get; set; }
    public string NameAr { get; set; } = null!;
    public string NameEn { get; set; } = null!;

    public virtual ICollection<Call> Calls { get; set; }
}
