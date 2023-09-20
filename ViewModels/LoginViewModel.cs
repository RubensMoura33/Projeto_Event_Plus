﻿using System.ComponentModel.DataAnnotations;

namespace webapi.event_manha.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email obrigatorio!")]

        public string? Email { get; set; }

        [Required(ErrorMessage ="Senha Obrigatoria")]

        public string? Senha { get; set; }
    }
}
