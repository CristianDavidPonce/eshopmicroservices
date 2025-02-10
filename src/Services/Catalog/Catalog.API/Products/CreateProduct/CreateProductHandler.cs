

using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;
public record CreateProductCommand(string Name, string Description, List<string> Category, string ImageFile, decimal Price) 
: ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            //Id = Guid.NewGuid(),
            Name = command.Name,
            Description = command.Description,
            Category = command.Category,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        
        throw new NotImplementedException();
    }
}
