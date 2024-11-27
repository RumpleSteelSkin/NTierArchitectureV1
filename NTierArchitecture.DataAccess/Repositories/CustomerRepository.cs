using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class CustomerRepository(ApplicationDBContext context) : GenericRepository<Customer>(context)
    {
    }
}
