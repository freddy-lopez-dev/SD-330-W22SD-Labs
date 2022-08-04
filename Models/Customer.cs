namespace SD_330_W22SD_Labs.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int Phone { get; set; }
        
        public virtual ICollection<Address>? Addresses { get; set; }
    }
}
