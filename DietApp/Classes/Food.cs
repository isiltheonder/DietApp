using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int ID { get; set; }

        public string PicturePath { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public double Calorie { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryID { get; set; }

        [Required, ForeignKey("DietFoods")]
        public int DietFoodID { get; set; }

        public ICollection<DietFood> DietFoods { get; set; } = new List<DietFood>();
        public Category Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
