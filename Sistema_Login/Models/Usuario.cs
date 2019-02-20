using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Login.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Nome obrigatorio!")]
        public string Nome { get; set; }
        [Range(18, 70, ErrorMessage = "Idade Entre 18 e 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*", ErrorMessage = "Digite um email valido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login obrigatorio!")]
        [Remote("Login", "Usuario", ErrorMessage = "Este login ja existe!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha obrigatoria!")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas diferentes")]
        public string ConfirmarSenha { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira alguma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }
    }
}