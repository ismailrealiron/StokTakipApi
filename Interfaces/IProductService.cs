using StokTakipApi.DTOs;
namespace StokTakipApi.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductDto dto);
        Task<bool> UpdateProductAsync(int id,ProductDto dto);
        Task<bool> DeleteProductAsync(int id);
    }
}
