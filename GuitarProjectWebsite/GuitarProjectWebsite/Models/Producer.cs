using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GuitarProjectWebsite.Validation;

namespace GuitarProjectWebsite.Models
{
    public class Producer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Url]
        [WebsiteExists]
        public string Website { get; set; }

        public IList<Guitar> Guitars { get; set; }
    }
}
