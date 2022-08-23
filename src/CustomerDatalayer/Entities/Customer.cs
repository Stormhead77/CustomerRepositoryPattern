namespace CustomerDatalayer.BusinessEntities
{
    public class Customer
    {
        public int Id { get; set; } = -1;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal? TotalPurchasesAmount { get; set; } = 0;
    }
}