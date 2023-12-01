namespace FrontEnd.Data;

public class CartItem
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ItemId { get; set; }
    public decimal ActualPrice { get; set; }
    public int Quantity { get; set; }

    public virtual Cart Cart { get; set; } = new Cart();
    public virtual Item Item { get; set; } = new Item();
}
