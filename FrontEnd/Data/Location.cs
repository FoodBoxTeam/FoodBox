using System;
using System.Collections.Generic;

namespace FrontEnd.Data;

public partial class Location
{
    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public string? State { get; set; }

    public string? City { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
