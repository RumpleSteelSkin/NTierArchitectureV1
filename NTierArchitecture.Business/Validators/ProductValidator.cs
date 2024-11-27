using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Ürün alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("Ürün adı minimum 1 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Ürün adı maximum 50 karakter olmalıdır.");

            RuleFor(x => x.Category)
                .NotNull().NotEmpty().WithMessage("Ürün kategorisi boş geçilemez.");

            RuleFor(x => x.Supplier)
                .NotNull().NotEmpty().WithMessage("Ürün tedarikçisi boş geçilemez.");

            RuleFor(x => x.UnitPrice)
                .NotNull().WithMessage("Ürün fiyatı girilmelidir.")
                .GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı negatif olamaz.");

            RuleFor(x => x.UnitsInStock)
                .NotNull().WithMessage("Ürün stok girilmelidir.");
        }
    }
}
