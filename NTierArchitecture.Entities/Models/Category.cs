using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    //ICollection : Koleksiyon türleri için temel bir arayüzdür. List, HashSet, LinkedList, Dictionary...
    public class Category : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Navigation Property
        public ICollection<Product>? Products { get; set; }
    }
}
