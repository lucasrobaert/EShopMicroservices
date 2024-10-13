namespace Catalog.Api.Products.GetProductByCategory;

public record GetProductByCategoryQuery(string Category) : IQuery<GetProductByCategory>;

public record GetProductByCategory(IEnumerable<Product> Products);

internal class GetProductByCategoryQueryHandler(
    IDocumentSession session) : IQueryHandler<GetProductByCategoryQuery, GetProductByCategory>
{
    public async Task<GetProductByCategory> Handle(GetProductByCategoryQuery request, CancellationToken cancellationToken)
    {
        var products = await session.Query<Product>()
            .Where(x => x.Category.Contains(request.Category))
            .ToListAsync(cancellationToken);
        
        return new GetProductByCategory(products);
    }
}