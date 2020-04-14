using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Models
{
    public class Master
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Возраст(лет)")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Стаж(лет)")]
        public int YearsOfWork { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public Master()
        {
            Services = new List<Service>();
        }
    }
}