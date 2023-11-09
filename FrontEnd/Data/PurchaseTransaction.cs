using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnd.Data;

public partial class PurchaseTransaction
{
    public int Id { get; set; }

    public int PurchaseId { get; set; }

    public bool? GotPaid { get; set; }

    public string CreditCardNumber { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal AmountPaid { get; set; }

    public virtual Purchase Purchase { get; set; } = null!;
}
