using FluentValidation;
using Hotelier.DtoLayer.Dtos.GuestDtos;

namespace Hotelier.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyadı Alanı Boş Geçilemez.");
            RuleFor(x=>x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter giriniz!");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("En az 3 karakter giriniz!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("En az 3 karakter giriniz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz!");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz!");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz!");
        }
    }
}
