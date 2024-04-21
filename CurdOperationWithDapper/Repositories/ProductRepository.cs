using CrudOperationWithDapper.DBContext;
using CrudOperationWithDapper.Interfaces;
using CrudOperationWithDapper.Models;
using Dapper;

namespace CrudOperationWithDapper.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly DapperDbContext context;

        public ProductRepository(DapperDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ProductModel>> Get()
        {
            var sql = $@"SELECT [ProductId],
                               [ProductName],
                               [Price]
                            FROM
                               [Products]";

            using var connection = context.CreateConnection();
            return await connection.QueryAsync<ProductModel>(sql);
        }
        public async Task<ProductModel> Find(Guid uid)
        {
            var sql = $@"SELECT [ProductId],
                               [ProductName],
                               [Price]
                            FROM
                               [Products]
                            WHERE
                              [ProductId]=@uid";

            using var connection = context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ProductModel>(sql, new { uid });
        }
        public async Task<ProductModel> Add(ProductModel model)
        {
            model.ProductId = Guid.NewGuid();
            var sql = $@"INSERT INTO [dbo].[Products]
                                ([ProductId],
                                 [ProductName],
                                 [Price])
                                VALUES
                                (@ProductId,
                                 @ProductName,
                                 @Price)";

            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<ProductModel> Update(ProductModel model)
        {
            var sql = $@"UPDATE[dbo].[Products]
                           SET [ProductId] = @ProductId,
                               [ProductName] = @ProductName,
                               [Price] = @Price
                          WHERE
                              ProductId=@ProductId";

            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<ProductModel> Remove(ProductModel model)
        {
            var sql = $@"
                        DELETE FROM
                            [dbo].[Products]
                        WHERE
                            [ProductId]=@ProductId";
            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
    }
}
