using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuitarProjectWebsite.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        public IList<Guitar> Guitars { get; set; }
    }
}
