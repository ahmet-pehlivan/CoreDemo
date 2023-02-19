using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Doldurunuz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Doldurunuz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Yükleyiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakter sınırını aşmayın");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4 karakterden fazla değer girin");
        }
    }
}
