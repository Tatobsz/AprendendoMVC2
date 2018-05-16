using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AprendendoMVC2.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage="O nome deve ser preenchido")]
        [StringLength(60, MinimumLength = 2, ErrorMessage="O nome deve conter no minimo 2 letras")]        
        public string Nome  {get; set;}

        [StringLength(200,MinimumLength = 5, ErrorMessage= "No minimo 5 caracteres, no maximo 200")]
        public string Observacao {get; set;}
         
        [Range(8,130, ErrorMessage="Idade minima 8 anos")]
        public string Idade {get; set;}

        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage="Email invalido")]
        public string Email {get; set;}

        [Required(ErrorMessage = "Preencha o login")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "O login deve conter no minimo 5 caracteres")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage="Login já existe")]
        public string Login {get; set;}

        [Required(ErrorMessage = "A senha deve ter no minimo 5 caracteres")]        
        public string Senha {get; set;}        
        
        [System.Web.Mvc.Compare("Senha", ErrorMessage="As senhas não coincidem")]
        public string ConfirmarSenha {get; set;}
    }
}