using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Supplier : Entity
    {
        public string? Name { get; set; }
        public string? ContactTitle { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }

        //Navigation Property
        public ICollection<Product>? Products { get; set; }
    }
}
