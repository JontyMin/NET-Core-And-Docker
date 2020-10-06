using System.Linq;
namespace ExampleApp.Models {
    public interface IProductRepository {
        IQueryable<Product> Products { get; }
    }
}