using ConsumerRab.Model;


namespace ConsumerRab.Service
{
    public interface IListProductService
    {
        Task<IEnumerable<ProductList>> GetAll();
    }
}
