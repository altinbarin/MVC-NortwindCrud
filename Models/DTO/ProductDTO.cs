namespace _10_MVC_NortwindCrud.Models.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
       

    }
}
