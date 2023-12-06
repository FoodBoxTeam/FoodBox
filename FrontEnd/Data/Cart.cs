namespace FrontEnd.Data;

public class Cart
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public virtual Customer Customer { get; set; } = null!;
    public virtual Restaurant Restaurant { get; set; } = null!;
    public virtual IEnumerable<CartItem> CartItems { get; set; } = new List<CartItem>();

}
