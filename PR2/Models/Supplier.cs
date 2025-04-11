using System;
using System.Collections.Generic;

namespace PR2.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public short IdSupplierType { get; set; }

    public string NameSupplier { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual SupplierType SupplierType { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterial { get; set; } = new List<SuppliersMaterial>();
}
