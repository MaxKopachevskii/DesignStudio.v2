using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Цена(за один час работы)")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img { get; set; }

        [Display(Name = "Мастер")]
        public int? MasterId { get; set; }
        public virtual Master Master { get; set; }
    }
}