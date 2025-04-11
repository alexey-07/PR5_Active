using System;
using System.Collections.Generic;

namespace PR2.Models;

public partial class MaterialType
{
    public short Id { get; set; }

    public string TypeMaterial { get; set; } = null!;

    public virtual ICollection<Material> Material { get; set; } = new List<Material>();
}
