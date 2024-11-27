using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class OrderDetailRepository(ApplicationDBContext context) : GenericRepository<OrderDetail>(context)
    {
        public void Delete(Guid orderId, Guid productId)
        {
            var orderDetail = _context?.OrderDetails
                .SingleOrDefault(od => od.OrderID == orderId && od.ProductID == productId);
            if (orderDetail != null)
            {
                _context?.OrderDetails.Remove(orderDetail);
                _context?.SaveChanges();
            }
        }
    }
}
