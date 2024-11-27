using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class OrderDetail : Entity
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        //Navigation Property
        public Product? Product { get; set; }
        public Guid ProductID { get; set; }
        public Order? Order { get; set; }
        public Guid OrderID { get; set; }

        public override string ToString()
        {
            return $"{Product?.Name} - {Quantity} Adet - {UnitPrice}TL";
        }
    }
}
