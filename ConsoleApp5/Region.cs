using System;
using System.Collections.Generic;

namespace ConsoleApp5;

public partial class Region
{
    public short RegionId { get; set; }

    public char RegionDescription { get; set; }

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
