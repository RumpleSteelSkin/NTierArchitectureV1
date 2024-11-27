using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Employee : Entity
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? FullName => $"{Name} {SurName}";
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }

        //Navigation Property
        public ICollection<Order>? Orders { get; set; }
    }
}
