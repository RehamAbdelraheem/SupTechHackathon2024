using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupTechHackathon2024.EFCore.Models;

public partial class MisSellingCategory
{
    public MisSellingCategory()
    {
        Calls = new HashSet<Call>();
    }

    public int Id { get; set; }
    public string NameAr { get; set; } = null!;
    public string NameEn { get; set; } = null!;

    public virtual ICollection<Call> Calls { get; set; }
}

