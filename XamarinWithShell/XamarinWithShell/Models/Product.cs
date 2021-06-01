namespace XamarinWithShell.Models
{
    public class Product : Item
    {
        public Product(string name = null) : base(name)
        {

        }

        public string SKU { get; set; }
        public string ImageUrl { get; set; }
    }
}
