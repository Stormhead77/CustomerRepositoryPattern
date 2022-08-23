namespace CustomerDatalayer.BusinessEntities
{
    public class Address
    {
        public int Id { get; set; } = -1;
        public int CustomerId { get; set; } = -1;
        public string AddressLine { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string Type { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
