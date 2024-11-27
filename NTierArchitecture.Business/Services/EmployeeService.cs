using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class EmployeeService(EmployeeRepository empRepo) : IManager<Employee>
    {
        private readonly EmployeeRepository _repository = empRepo;
        public void Create(Employee entity)
        {
            if (IfEntityExists(entity))
                throw new Exception("Bu çalışan daha önce kayıt edilmiştir.");
            ValidationResult result = new EmployeeValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir çalışan silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Employee>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Çalışan bulunmamaktadır.");
        }

        public Employee? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Employee entity)
        {
            return _repository.IfEntityExists(c => c.Name == entity.Name && c.SurName == entity.SurName);
        }

        public void Update(Employee entity)
        {
            ValidationResult result = new EmployeeValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
