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
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 00",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-4.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 10",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-5.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 20",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-6.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 30",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-7.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 40",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-8.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 50",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-9.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 60",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-10.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 70",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-11.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 80",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-12.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Huawei 99",
            Description = "This phone is the company's biggest change to its own.",
            ImageFile = "product-13.png",
            Price = 950.00M,
            Category = ["Smart Phone"]
        },
        
    };
}