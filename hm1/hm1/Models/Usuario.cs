using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hm1.Models
{
    [FluentValidation.Attributes.Validator(typeof(Validacion))]
    public class Usuario
        
    {
     
        [Display(Name ="Nombre de usuario")]
        public string UserName{get; set;}

        [Display(Name = "Contrasena")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirme Constrasena")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}