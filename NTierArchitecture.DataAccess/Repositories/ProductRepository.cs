using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class ProductRepository(ApplicationDBContext context) : GenericRepository<Product>(context)
    {
    }
}
