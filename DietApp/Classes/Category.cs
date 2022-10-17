using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("Foods")]
        public int FoodID { get; set; }

        [Required, MaxLength(50)]
        public string Description { get; set; }

        public ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
