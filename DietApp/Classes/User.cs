using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }

        [ForeignKey("UserDetails")]
        public int? UserDetailID { get; set; }

        [Required]
        public string SecurityQuestion { get; set; }

        [Required]
        public string SecurityAnswer { get; set; }

        [Required]
        public bool IsAdmin { get; set; } = false;

        [Required]
        public DateTime AccountCreationDate { get; private set; } = DateTime.Now;

        [ForeignKey("Diets")]
        public int? DietID { get; set; }

        public ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();
        public ICollection<Diet> Diets { get; set; } = new List<Diet>();
    }
}
