using System;
using System.Collections.Generic;

namespace magnit.Models;

public partial class RevenueHistory
{
    public int Id { get; set; }

    public int IdEmployee { get; set; }

    public short IdSalesRegisters { get; set; }

    public decimal Revenue { get; set; }

    public DateOnly Date { get; set; }

    public DateTime TimeStart { get; set; }

    public DateTimeOffset TimeEnd { get; set; }

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual SalesRegister IdSalesRegistersNavigation { get; set; } = null!;
}
