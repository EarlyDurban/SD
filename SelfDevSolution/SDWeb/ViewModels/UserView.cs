using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDWeb.ViewModels
{
    public class UserView
    {
        //   public int UserID { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Required(ErrorMessage = "Введите Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 6, ErrorMessage = "Длина строки должна быть от 6 до 50 символов")]
        [Required(ErrorMessage = "Введите пароль")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Введите подтверждение пароля")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        public int Captcha { get; set; }

        public string AvatarPAth { get; set; }
    }
}