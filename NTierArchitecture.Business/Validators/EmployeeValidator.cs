using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().NotNull().WithMessage("Çalışan Adı alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("Çalışan Adı minimum 1 karakter olmalıdır.")
                .MaximumLength(35).WithMessage("Çalışan Adı maximum 35 karakter olmalıdır.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.SurName)
                .NotEmpty().NotNull().WithMessage("Çalışan Soyadı alanı boş geçilemez.")
                .MinimumLength(1).WithMessage("Çalışan Soyadı minimum 1 karakter olmalıdır.")
                .MaximumLength(15).WithMessage("Çalışan Soyadı maximum 15 karakter olmalıdır.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.City)
                .NotEmpty().NotNull().WithMessage("Şehir adı boş geçilemez.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.Country)
                .NotEmpty().NotNull().WithMessage("Ülke adı boş geçilemez.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.Phone)
                .NotEmpty().NotNull().WithMessage("Telefon numarası gereklidir.")
                .MinimumLength(10).WithMessage("Telefon numarası 10 karakterden küçük olmamalıdır.")
                .MaximumLength(20).WithMessage("Telefon numarası 20 karakteri geçmemelidir.")
                .Matches(ReadyRegexes.PhoneFormat).WithMessage("Telefon numarası gerekli formatta değildir.");
        }
    }
}
