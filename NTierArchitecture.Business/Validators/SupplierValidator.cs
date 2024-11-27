using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Tedarikçi alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("Tedarikçi adı minimum 1 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Tedarikçi adı maximum 50 karakter olmalıdır.");

            RuleFor(x => x.ContactTitle)
                .NotNull().NotEmpty().WithMessage("İletişim adı alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("İletişim adı minimum 1 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("İletişim adı maximum 50 karakter olmalıdır.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir adı boş geçilemez.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("Ülke adı boş geçilemez.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.Phone)
                .NotEmpty().NotNull().WithMessage("Telefon numarası gereklidir.")
                .MinimumLength(10).WithMessage("Telefon numarası 10 karakterden küçük olmamalıdır.")
                .MaximumLength(20).WithMessage("Telefon numarası 20 karakteri geçmemelidir.")
                .Matches(ReadyRegexes.PhoneFormat).WithMessage("Telefon numarası gerekli formatta değildir.");
        }
    }
}
