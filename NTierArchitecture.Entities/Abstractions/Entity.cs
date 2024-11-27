namespace NTierArchitecture.Entities.Abstractions
{
    //abstract: Entity sınıfı new lemez. Bu sınıftan yeni bir Entity nesnesi türetilsin istemiyoruz.
    public abstract class Entity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
