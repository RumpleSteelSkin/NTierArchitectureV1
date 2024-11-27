using NTierArchitecture.Entities.Abstractions;
using System.Linq.Expressions;

namespace NTierArchitecture.DataAccess.Abstractions
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void DeleteById(Guid id);
        T? GetById(Guid id);
        IEnumerable<T>? GetAll();
        bool IfEntityExists(Expression<Func<T,bool>> filter);
    }
}
