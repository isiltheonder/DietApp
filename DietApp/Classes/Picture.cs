using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Classes
{
    [Table("Pictures")]
    public class Picture
    {
        [Key]
        public int ID { get; set; }

        public string Path { get; set; }

        public override string ToString()
        {
            return Path;
        }
    }
}
