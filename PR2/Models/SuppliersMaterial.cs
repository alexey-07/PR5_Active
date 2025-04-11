using System;
using System.Collections.Generic;

namespace PR2.Models;

public partial class SuppliersMaterial
{
    public int Id { get; set; }

    public int IdSupplier { get; set; }

    public int IdMaterial { get; set; }

    public short CountPack { get; set; }

    public DateOnly DateOfSupply { get; set; }

    public decimal CostForPack { get; set; }

    public short QualitySupply { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
