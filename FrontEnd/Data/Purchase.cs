using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class Purchase
{
    public int Id { get; set; }

    public decimal? TaxRate { get; set; }

    public int? CouponId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public virtual Coupon? Coupon { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = new Restaurant();

    public virtual ICollection<PurchaseItem> PurchaseItems { get; set; } = new List<PurchaseItem>();

    public virtual Customer Customer { get; set; } = new Customer();

    public virtual ICollection<PurchaseTransaction> PurchaseTransactions { get; set; } = new List<PurchaseTransaction>();
}
