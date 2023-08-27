using System;
using System.Collections.Generic;

namespace IdentityServer_MVC.Models.DB;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid OrderedBy { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool? DiscountApplied { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public virtual Product Product { get; set; } = null!;
}
