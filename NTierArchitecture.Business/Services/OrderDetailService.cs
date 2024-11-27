using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService(OrderDetailRepository odRepo) : IManager<OrderDetail>
    {
        private readonly OrderDetailRepository _repository = odRepo; 
        public void Create(OrderDetail entity)
        {
            ValidationResult result = new OrderDetailValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir sepet detayı silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<OrderDetail>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Sepet detayı bulunmamaktadır.");
        }

        public OrderDetail? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(OrderDetail entity)
        {
            return _repository.IfEntityExists(c => c.ID == entity.ID);
        }

        public void Update(OrderDetail entity)
        {
            ValidationResult result = new OrderDetailValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
