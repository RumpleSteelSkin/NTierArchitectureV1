using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class EmployeeRepository(ApplicationDBContext context) : GenericRepository<Employee>(context)
    {
    }
}
