using AutoMapper;
using ProySuministros.Business.Layer.DataContracts;
using ProySuministros.Business.Layer.Services.Interfaces;
using ProySuministros.DataAccess.Layer.Models;
using ProySuministros.DataAccess.Layer.Repositories.Interfaces;
using ProySuministros.DataAccess.Layer.UnitOfWork;

namespace ProySuministros.Business.Layer.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            IEnumerable<Product> products = await _productRepository.GetProducts();
            return _mapper.Map<List<ProductDto>>(products);
        }
        public async Task<ProductDto> InsertProducts(ProductDto productDto)
        {
            Product product = await _productRepository.InsertProducts(_mapper.Map<Product>(productDto));
            _unitOfWork.SaveChanges();
            return _mapper.Map<ProductDto>(product);
        }
    }
}
