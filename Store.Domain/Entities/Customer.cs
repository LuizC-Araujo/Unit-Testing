using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;

            AddNotifications(new Contract<Customer>()
                .Requires()
                .IsNotNull(name, "Name", "Nome inválido!")
                .IsNotNull(email, "Email", "Email inválido"));
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
