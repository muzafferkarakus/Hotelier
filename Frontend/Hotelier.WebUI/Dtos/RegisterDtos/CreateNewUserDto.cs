﻿using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.Dtos.RegisterDtos
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadı Alanı Gereklidir.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "E-Posta Alanı Gereklidir.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Parola Alanı Gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Parola Tekrar Alanı Gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
