using EntityLayerr.Concerete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidatior : AbstractValidator<Contact>
    {
        public ContactValidatior()
        {
            RuleFor(x=>x.ContactName).NotEmpty().WithMessage("Adınız Boş Olamaz");
            RuleFor(x=>x.ContactNumber).NotEmpty().WithMessage("Telefon Numaranız Boş Olamaz");
            RuleFor(x=>x.ContactEmail).NotEmpty().WithMessage("Email Adresiniz Boş Olamaz");
            RuleFor(x=>x.ContactMessage).NotEmpty().WithMessage("Mesaj Boş Olamaz");
            RuleFor(x=>x.ContactMessage).MinimumLength(3).WithMessage("Mesaj En az 3 karakter içermeli");
            RuleFor(x=>x.ContactMessage).MaximumLength(50).WithMessage("Mesaj En fazla 50 karakter içermeli");
        }
    }
}
