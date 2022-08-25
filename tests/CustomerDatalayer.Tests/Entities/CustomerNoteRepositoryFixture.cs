using CustomerDatalayer.Entities;
using CustomerDatalayer.Repositories;

namespace CustomerDatalayer.Tests.Entities
{
    public static class CustomerNotesRepositoryFixture
    {
        public static void DeleteAll()
        {
            CustomerNoteRepository repository = new();
            repository.DeleteAll();
        }

        public static CustomerNote GetAddress()
        {
            CustomersRepositoryFixture.DeleteAll();
            CustomerRepository repository = new();
            var customer = CustomersRepositoryFixture.GetCustomer();
            var createdCustomer = repository.Create(customer);

            var address = new CustomerNote
            {
                CustomerId = createdCustomer.Id,
                NoteText = "text"
            };

            return address;
        }
    }
}
