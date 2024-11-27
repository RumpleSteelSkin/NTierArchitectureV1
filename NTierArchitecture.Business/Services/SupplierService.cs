using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class SupplierService(SupplierRepository supRepo) : IManager<Supplier>
    {
        private readonly SupplierRepository _repository = supRepo;
        public void Create(Supplier entity)
        {
            if (IfEntityExists(entity))
                throw new Exception("Bu tedarikçi daha önce kayıt edilmiştir.");
            ValidationResult result = new SupplierValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir tedarikçi silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Supplier>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Tedarikçi bulunmamaktadır.");
        }

        public Supplier? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Supplier entity)
        {
            return _repository.IfEntityExists(c => c.Name == entity.Name);
        }

        public void Update(Supplier entity)
        {
            ValidationResult result = new SupplierValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
