using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("DietFoods")]
    public class DietFood
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("Food")]
        public int FoodID { get; set; }

        [Required, ForeignKey("Diet")]
        public int DietID { get; set; }

        public Food Food { get; set; }
        public Diet Diet { get; set; }
    }
}
