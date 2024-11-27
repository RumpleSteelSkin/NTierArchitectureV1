using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class CategoryRepository(ApplicationDBContext context) : GenericRepository<Category>(context)
    {
    }
}
