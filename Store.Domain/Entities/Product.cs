using Flunt.Validations;

namespace Store.Domain.Entities;

public class Product : Entity
{
    public Product(string title, decimal price, bool active)
    {
        Title = title;
        Price = price;
        Active = active;
        
        AddNotifications(new Contract<Product>()
            .Requires()
            .IsNotNullOrEmpty(title, "Title", "Título inválido!")
            .IsNotNullOrWhiteSpace(title, "Title", "Título inválido!")
            .IsNotNull(price, "Price", "Preço inválido")
            .IsGreaterThan(price, 0, "Price")
            .IsNotNull(active, "Active", "O ativo deve ser verdadeiro ou falso"));
            
    }

    public string Title { get; private set; }
    public decimal Price { get; private set; }
    public bool Active { get; private set; }
}