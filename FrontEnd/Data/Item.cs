﻿using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class Item
{
    public int Id { get; set; }

    public string ItemName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();

    public virtual ICollection<PurchaseItem> PurchaseItems { get; set; } = new List<PurchaseItem>();

    public virtual ICollection<RestaurantItem> RestaurantItems { get; set; } = new List<RestaurantItem>();
}