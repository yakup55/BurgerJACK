using EntityLayerr.Concerete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BurgerValidatior: AbstractValidator<Burger>
    {
        public BurgerValidatior()
        {
            RuleFor(x => x.BurgerName).NotEmpty().WithMessage("Burger Adı Boş Olamaz");
            RuleFor(x => x.BurgerSpecification).NotEmpty().WithMessage("Burger Tarifi Boş Olamaz");
            RuleFor(x => x.BurgerPrice).NotEmpty().WithMessage("Burger Fiyatı Boş Olamaz");
            RuleFor(x => x.BurgerImage).NotEmpty().WithMessage("Burger Resmi Boş Olamaz");

        }
    }
}
