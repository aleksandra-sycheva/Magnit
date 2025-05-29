using System;
using System.Collections.Generic;

namespace magnit.Models;

public partial class TypesOfEmployee
{
    public short Id { get; set; }

    public string TypeOfEmployee { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
