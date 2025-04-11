using System;
using System.Collections.Generic;

namespace PR2.Models;

public partial class Material
{
    public int Id { get; set; }

    public short IdMaterialType { get; set; }

    public string NameMaterial { get; set; } = null!;

    public short CountInPack { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }


    //навигационные свойства
    public virtual MaterialType MaterialType { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterial { get; set; } = new List<SuppliersMaterial>();
}
