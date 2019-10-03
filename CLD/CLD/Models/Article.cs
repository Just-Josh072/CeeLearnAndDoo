using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Article
    {
        public int id { get; set; }
        public int ConsultantId { get; set; }
        public int CategoryId { get; set; }
        public char Title { get; set; }
        public DateTime CreationDate { get; set; }
        public char Content { get; set; }
        public bool isVisible { get; set; }
        public string test { get; set; }

    }
}
