using System;
using System.Collections.Generic;

namespace magnit.Models;

public partial class Employee
{
    public int Id { get; set; }

    public short IdTypeOfEmployee { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string ResidentialAddress { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly DateOfEmployment { get; set; }

    public DateOnly? DateOfDismissal { get; set; }

    public string Photo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual TypesOfEmployee IdTypeOfEmployeeNavigation { get; set; } = null!;

    public virtual ICollection<RevenueHistory> RevenueHistories { get; set; } = new List<RevenueHistory>();
}
