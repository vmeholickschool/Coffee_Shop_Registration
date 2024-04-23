using System;
using System.Collections.Generic;

namespace Coffee_Shop_Registration;

public partial class Product
{
    public int Id { get; set; }
    public int ID { get; internal set; }
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? Category { get; set; }
}
