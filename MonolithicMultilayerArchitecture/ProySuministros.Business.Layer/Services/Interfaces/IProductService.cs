using ProySuministros.Business.Layer.DataContracts;

namespace ProySuministros.Business.Layer.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> InsertProducts(ProductDto productDto);
    }
}
