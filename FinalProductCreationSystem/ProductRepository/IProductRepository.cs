using FinalProductCreationSystem.Model;
using System;
using System.Collections.Generic;

namespace FinalProductCreationSystem.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Guid id);
    }
}
