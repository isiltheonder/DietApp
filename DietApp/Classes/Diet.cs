using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("Diets")]
    public class Diet
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("User")]
        public int UserID { get; set; }

        [Required, ForeignKey("DietFoods")]
        public int DietFoodID { get; set; }

        [Required]
        public double TotalCalories { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public Meal Meal { get; set; }

        public User User { get; set; }
        public ICollection<DietFood> DietFoods { get; set; } = new List<DietFood>();
    }
}
