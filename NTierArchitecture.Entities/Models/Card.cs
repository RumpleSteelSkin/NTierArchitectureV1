namespace NTierArchitecture.Entities.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public List<CardItem> CardItems { get; set; } = [];


        public void AddItem(CardItem item)
        {
            var p = CardItems.FirstOrDefault(x => x.ProductID == item.ProductID);
            if (p != null)
            {
                double firstPrice = p.UnitPrice / p.Quantity;
                p.Quantity += item.Quantity;
                p.UnitPrice = firstPrice * p.Quantity;
            }
            else
            {
                item.UnitPrice = item.Quantity * item.UnitPrice;
                CardItems.Add(item);
            }
        }

        public void DeleteItem(Guid cardItemID)
        {
            var p = CardItems.FirstOrDefault(x => x.CardItemID == cardItemID);

            if (p != null)
            {
                double firstPrice = p.UnitPrice / p.Quantity;
                p.Quantity -= 1;
                p.UnitPrice = firstPrice * p.Quantity;
                if (p.Quantity == 0)
                {
                    CardItems.Remove(p);
                }
            }
        }
    }
}
