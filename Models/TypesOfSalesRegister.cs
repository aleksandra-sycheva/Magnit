using System;
using System.Collections.Generic;

namespace magnit.Models;

public partial class TypesOfSalesRegister
{
    public short Id { get; set; }

    public string TypeOfSalesRegisters { get; set; } = null!;

    public virtual ICollection<SalesRegister> SalesRegisters { get; set; } = new List<SalesRegister>();
}
