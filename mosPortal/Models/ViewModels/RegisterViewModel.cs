﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mosPortal.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Vorname",Prompt ="Vorname")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Nachname", Prompt = "Nachname")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "EMail", Prompt = "example@web.de")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Benutzername", Prompt = "Benutzername")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Geburtsort", Prompt = "Geburtsort")]
        public string Birthplace { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Geburtstag")]
        public DateTime Birthday { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Das {0} muss min. {2} und max. {1} Zeichen lang sein.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Passwort", Prompt = "Passwort")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Die beiden Passwörter stimmen nicht überein!")]
        [DataType(DataType.Password)]
        [Display(Name = "Passwort bestätigen", Prompt = "Passwort")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int ZipCode { get; set; }



    }
}
