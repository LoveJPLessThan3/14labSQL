using System;
using System.Collections.Generic;
using ConsoleApp5.Code;

namespace ConsoleApp5;

public partial class Category : ICategory
{
    public short CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
