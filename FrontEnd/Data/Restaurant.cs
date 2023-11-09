using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class Restaurant
{
    public int Id { get; set; }

    public string RestaurantName { get; set; } = null!;

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<RestaurantItem> RestaurantItems { get; set; } = new List<RestaurantItem>();
}
