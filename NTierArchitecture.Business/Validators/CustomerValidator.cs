using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Müşteri adı alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("Müşteri adı minimum 1 karakter olmalıdır.")
                .MaximumLength(35).WithMessage("Müşteri adı maximum 35 karakter olmalıdır.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

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
