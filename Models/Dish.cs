using System;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;
namespace Csharp_CRUDelicious.Models
{

    public class Dish
    {
        // auto-implemented properties need to match columns in your table
        [Key]
        public int DishId { get; set; }

        [Required(ErrorMessage="Please enter a ")]
        [DisplayName("Name")]
        [MinLength(3)]
        [MaxLength(42, ErrorMessage="Please use a shorter ")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter a ")]
        [DisplayName("Chef")]
        [MinLength(3)]
        [MaxLength(42, ErrorMessage="Please use a shorter ")]
        public string Chef { get; set; }

        [Required()]
        [Range(0, 5)]
        [DisplayName("Tastiness")]
        public int Tastiness { get; set; }

        [Required(ErrorMessage = "Please enter ")]
        [DisplayName("Calories")]
        [Range(1, 5000, ErrorMessage = "1 to 5000, if more than 5000 calories, you shouldn't eat it. enter a new ")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "Please enter a ")]
        [DisplayName("Description")]
        [MinLength(3)]
        public string Description { get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

        public Dish(){}
    }
}
