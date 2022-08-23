using EntityLayerr.Concerete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidatior: AbstractValidator<Comment>
    {
        public CommentValidatior()
        {
           RuleFor(x=>x.CommentName).NotEmpty().WithMessage("Adınız Boş Olamaz");
           RuleFor(x => x.CommentMail).NotEmpty().WithMessage("Mail Adresi Boş olamaz");
           RuleFor(x => x.CommentSubject).NotEmpty().WithMessage("Konu Boş olamaz");
           RuleFor(x => x.CommentSubject).MinimumLength(3).WithMessage("Konu en az 3 karakter olabilir");
           RuleFor(x => x.CommentSubject).MaximumLength(20).WithMessage("Konu en fazla 20 karakter olabilir");
            RuleFor(x => x.CommentMessage).MinimumLength(3).WithMessage("Mesaj en az 3 karakter olabilir");
            RuleFor(x => x.CommentMessage).MaximumLength(50).WithMessage("Mesaj en fazla 50 karakter olabilir");
        }
    }
}
