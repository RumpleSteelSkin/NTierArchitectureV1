using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class OrderService(OrderRepository ordRepo) : IManager<Order>
    {
        private readonly OrderRepository _repository = ordRepo;
        public void Create(Order entity)
        {
            if (IfEntityExists(entity))
                throw new Exception("Bu Sipariş daha önce yapılmıştır.");
            ValidationResult result = new OrderValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir sipariş silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Order>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Sipariş bulunmamaktadır.");
        }

        public Order? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Order entity)
        {
            return _repository.IfEntityExists(c => c.OrderDate == entity.OrderDate && c.EmployeeID == entity.EmployeeID && c.CustomerID == entity.CustomerID);
        }

        public void Update(Order entity)
        {
            ValidationResult result = new OrderValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
