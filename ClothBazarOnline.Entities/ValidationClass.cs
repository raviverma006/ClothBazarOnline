using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazarOnline.Entities
{
   public  class ValidationClass
    {
        [Key]
        public int  Id { get; set; }

        [Required]
        [Display(Name ="Name")]
        [MinLength(5), MaxLength(50)]
         
        public string Name { get; set; }

        public string Username { get; set; }

        [EmailAddress]
        public string Email    { get; set; }

        [Range(1,500,ErrorMessage ="Plaese enter in Range")]
        public int Price { get; set; }

    }
}
