using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnd.Data;

public partial class PurchaseItem
{
    public int Id { get; set; }

    public int PurchaseId { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal ActualPrice { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Purchase Purchase { get; set; } = null!;
}
