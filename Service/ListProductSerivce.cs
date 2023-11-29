using ConsumerRab.Data;
using ConsumerRab.Model;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Store_1.Model;

namespace ConsumerRab.Service
{
    public class ListProductSerivce : IListProductService, IConsumer<Product>
    {
        private readonly DataContext _dataContext;

        public ListProductSerivce(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Consume(ConsumeContext<Product> context)
        {
            var product = context.Message;

            var newBasket = new ProductList
            {
                ProductName = product.productName,
                Quantity = 1,
                Price = product.price,
                ClientName = "Vasya"
            };
            _dataContext.Set<ProductList>().Add(newBasket);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductList>> GetAll()
        {
            return await _dataContext.Set<ProductList>().ToListAsync();
        }

    }
}
