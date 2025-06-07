﻿using StokTakipApi.Entities;

namespace StokTakipApi.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        void Update(Product product);
        void Delete(Product product);
        Task<bool> SaveChangesAsync();
    }
}
