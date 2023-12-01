﻿using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class Customer
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int? Points { get; set; }

    public virtual ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();
    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
