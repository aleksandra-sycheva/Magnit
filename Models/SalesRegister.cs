using System;
using System.Collections.Generic;

namespace magnit.Models;

public partial class SalesRegister
{
    public short Id { get; set; }

    public short IdTypeOfSalesRegisters { get; set; }

    public string Name { get; set; } = null!;

    public virtual TypesOfSalesRegister IdTypeOfSalesRegistersNavigation { get; set; } = null!;

    public virtual ICollection<RevenueHistory> RevenueHistories { get; set; } = new List<RevenueHistory>();
}
