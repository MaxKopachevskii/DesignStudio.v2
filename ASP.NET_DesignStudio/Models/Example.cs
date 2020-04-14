using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Models
{
    public class Example
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Desc { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img { get; set; }
    }
}