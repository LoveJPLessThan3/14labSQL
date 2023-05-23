using System;
using System.Collections.Generic;

namespace ConsoleApp5;

public partial class ProductsAudit
{
    public string? ProductName { get; set; }

    public float? OldUnitPrice { get; set; }

    public float? NewUnitPrice { get; set; }

    public DateTime? LastDate { get; set; }
}
