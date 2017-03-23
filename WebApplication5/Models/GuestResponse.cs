using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Пожалуйста, Введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некоректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Пожалуйста, укажите, примите ли Вы участие в вечеринке")]
        public bool? WillAttend { get; set; }
         
    }
}