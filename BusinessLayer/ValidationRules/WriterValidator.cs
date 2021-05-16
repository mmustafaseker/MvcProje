using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkındayı boş geçemezsiniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Lütfen şifre giriniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
        }
    }
}
