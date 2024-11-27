using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class SupplierRepository(ApplicationDBContext context) : GenericRepository<Supplier>(context)
    {
    }
}
