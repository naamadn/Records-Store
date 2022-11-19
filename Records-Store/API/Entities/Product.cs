namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Genre { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}