using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.ProductID)
                .NotNull().NotEmpty().WithMessage("Ürün ID bilgisi boş olamaz");

            RuleFor(x => x.OrderID)
                .NotNull().NotEmpty().WithMessage("Sipariş ID bilgisi boş olamaz");

            RuleFor(x => x.Quantity)
                .NotNull().WithMessage("Sepete toplam adet girilmelidir.")
                .GreaterThanOrEqualTo(1).WithMessage("Sepet onayı için en az 1 ürün olmalıdır.");

            RuleFor(x => x.UnitPrice)
                .NotNull().WithMessage("Sepet onayı için en az 1 ürün olmalıdır.")
                .GreaterThanOrEqualTo(0).WithMessage("Sepet fiyatı negatif olamaz.");
        }
    }
}
