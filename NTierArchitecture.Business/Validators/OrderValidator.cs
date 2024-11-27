using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.OrderDate)
                .NotNull().NotEmpty().WithMessage("Sipariş günü girilmelidir.")
                .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Sipariş tarihi bugünün tarihinden önceki bir tarih olamaz.");

            RuleFor(x => x.ShipAddress)
                .NotNull().NotEmpty().WithMessage("Siparişin ulaşacağı adres girilmelidir.")
                .MinimumLength(15).WithMessage("Siparişin ulaşacağı adres minimum 15 karakter olmalıdır.")
                .MaximumLength(500).WithMessage("Siparişin ulaşacağı adres 500 karakteri geçmemelidir.");

            RuleFor(x => x.ShipCity)
                .NotNull().NotEmpty().WithMessage("Siparişin ulaşacağı şehir girilmelidir.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.ShipCountry)
                .NotNull().NotEmpty().WithMessage("Siparişin ulaşacağı ülke girilmelidir.")
                .Matches(ReadyRegexes.NoNumberFormat).WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(x => x.Employee)
                .NotNull().NotEmpty().WithMessage("Siparişin çalışan bilgisi boş olamaz.");

            RuleFor(x => x.Customer)
                .NotNull().NotEmpty().WithMessage("Siparişin müşteri bilgisi boş olamaz.");
        }
    }
}
