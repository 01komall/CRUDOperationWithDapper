using CrudOperationWithDapper.Models;

namespace CrudOperationWithDapper.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<ProductModel>> Get();
        Task<ProductModel> Find(Guid uid);
        Task<ProductModel> Add(ProductModel model);
        Task<ProductModel> Update(ProductModel model);
        Task<ProductModel> Remove(ProductModel model);
    }
}
