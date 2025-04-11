using System;
using System.Collections.Generic;

namespace PR2.Models;

public partial class SupplierType
{
    public short Id { get; set; }

    public string TypeSupplier { get; set; } = null!;


    //навигационные свойства
    public virtual ICollection<Supplier> Supplier { get; set; } = new List<Supplier>();
}
