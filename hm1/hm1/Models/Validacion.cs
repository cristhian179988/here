using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hm1.Models
{
    public class Validacion:AbstractValidator<Usuario>
    {
        public Validacion()
        {
            RuleFor(x => x.UserName).NotNull().Length(10, 20);
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x=>x.Password);
            RuleFor(x => x.Email).NotNull().EmailAddress();
        }
    }
}