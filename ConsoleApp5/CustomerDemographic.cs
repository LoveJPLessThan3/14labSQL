﻿using System;
using System.Collections.Generic;

namespace ConsoleApp5;

public partial class CustomerDemographic
{
    public char CustomerTypeId { get; set; }

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
