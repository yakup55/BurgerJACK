using EntityLayerr.Concerete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adı boş olamaz");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Bırakamazsın");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En az 3 Karakter Giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen En Fazla 100 Karakter Giriniz");
        }
    }
}
