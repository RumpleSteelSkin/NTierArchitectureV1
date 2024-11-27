using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class OrderRepository(ApplicationDBContext context) : GenericRepository<Order>(context)
    {
    }
}
