using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class ProductService(ProductRepository proRepo) : IManager<Product>
    {
        private readonly ProductRepository _repository = proRepo;
        public void Create(Product entity)
        {
            if (IfEntityExists(entity))
                throw new Exception("Bu ürün daha önce kayıt edilmiştir.");
            ValidationResult result = new ProductValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir ürün silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Product>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Ürün bulunmamaktadır.");
        }

        public Product? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Product entity)
        {
            return _repository.IfEntityExists(c => c.Name == entity.Name && c.CategoryID == entity.CategoryID);
        }

        public void Update(Product entity)
        {
            ValidationResult result = new ProductValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
