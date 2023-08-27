using System;
using System.Collections.Generic;

namespace IdentityServer_MVC.Models.DB;

public partial class Product
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public short? Quantity { get; set; }

    public DateTime? AddedOn { get; set; }

    public Guid? AddedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsFeatured { get; set; }

    public decimal? Price { get; set; }

    public string? ProductImage { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
