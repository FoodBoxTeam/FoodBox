using System;
using System.Collections.Generic;

namespace FBAPI.Data;

public partial class Customer
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int? Points { get; set; }

    public virtual ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();

    public virtual AspNetUser User { get; set; } = null!;
}
