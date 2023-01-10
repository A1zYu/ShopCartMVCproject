namespace ShopCart.Web.Models
{
    public class CardItem
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal  Price  { get; set; }
        public decimal Total 
        {
            get { return Quantity * Price; }
        }
        public string Image { get; set; }
        public CardItem()
        {

        }
        public CardItem(Product product)
        {
            ProductId = product.Id;
            Name = product.Name;
            Price = product.Price;
            Quantity = 1;
            Image = product.Image;
        }
    }
}
