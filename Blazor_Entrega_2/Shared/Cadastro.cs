using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorCadastro.Shared
{
    public class Cadastro
    {
        [Required]
        public int titulozinho { get; set; }

        [Required]
        public string nomezinho { get; set; }
        
        [Required]
        public string sobrenomezinho { get; set; }
        
        [Required]
        public DateTime datinhanascimento { get; set; }

        [Required]
        [EmailAddress]
        public string emailzinho { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Mínimo de 8 caracteres")]
        public string senhazinha { get; set; }

        [Required]
        [Compare("senhazinha", ErrorMessage = "Senha diferente")]
        public string confirmasenhazinha { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceitar os termos é obrigatório")]
        public bool confirmacaozinha { get; set; }

    }
}