using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("UserDetails")]
    public class UserDetail
    {
        [Key]
        public int ID { get; set; }

        [Required, ForeignKey("User")]
        public int UserID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public int Age { get; set; }

        public User User { get; set; }
    }
}
