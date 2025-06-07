using AutoMapper;
using StokTakipApi.DTOs;
using StokTakipApi.Entities;
using StokTakipApi.Interfaces;

namespace StokTakipApi.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }

        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            var products = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            return product == null ? null : _mapper.Map<ProductDto>(product);
        }

        public async Task AddProductAsync(ProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _repo.AddAsync(product);
            await _repo.SaveChangesAsync();
        }

        public async Task<bool> UpdateProductAsync(int id, ProductDto dto)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null)
                return false;
            _mapper.Map(dto, product);
            _repo.Update(product);
            return await _repo.SaveChangesAsync();
        }
        

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null)
                return false;
            _repo.Delete(product);
            return await _repo.SaveChangesAsync();
        }
    }
}
