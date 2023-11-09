using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class PurchaseTransaction
{
    public int Id { get; set; }

    public int PurchaseId { get; set; }

    public bool? GotPaid { get; set; }

    public string CreditCardNumber { get; set; } = null!;

    public virtual Purchase Purchase { get; set; } = null!;
}
