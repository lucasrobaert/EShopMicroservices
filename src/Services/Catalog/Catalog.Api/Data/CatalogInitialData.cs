using Marten.Schema;

namespace Catalog.Api.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync(cancellation))
            return;
        
        session.Store<Product>(GetPreconfiguredProducts());
        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Iphone X",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-1.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Samsung Galaxy S5",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-2.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei X",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-3.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        
    };
}