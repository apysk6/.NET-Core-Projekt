using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarProjectWebsite.Models
{
    public class Guitar
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(3000, ErrorMessage = "Description cannot be longer than 50 characters.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public byte[] Image { get; set; }

        public int ProducerID { get; set; }

        public Producer Producer { get; set; }

        public int CategoryID { get; set; }
        
        public Category Category { get; set; }

    }
}
