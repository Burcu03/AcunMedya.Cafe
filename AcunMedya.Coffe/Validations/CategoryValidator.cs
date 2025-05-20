using AcunMedya.Coffe.Entities;
using FluentValidation;

namespace AcunMedya.Coffe.Validations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez").
              MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");

        }
    }
}
