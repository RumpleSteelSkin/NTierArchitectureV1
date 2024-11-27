using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class CustomerService(CustomerRepository cusRepo) : IManager<Customer>
    {
        private readonly CustomerRepository _repository = cusRepo;
        public void Create(Customer entity)
        {
            if (IfEntityExists(entity))
                throw new Exception("Bu müşteri daha önce kayıt edilmiştir.");
            ValidationResult result = new CustomerValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir müşteri silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Customer>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Müşteri bulunmamaktadır.");
        }

        public Customer? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Customer entity)
        {
            return _repository.IfEntityExists(c => c.Name == entity.Name && c.Phone == entity.Phone);
        }

        public void Update(Customer entity)
        {
            ValidationResult result = new CustomerValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
