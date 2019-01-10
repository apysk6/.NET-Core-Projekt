using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarProjectWebsite.Models
{
    public class GuitarViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Producer Producer { get; set; }
        public string Website { get; set; }
    }
}
