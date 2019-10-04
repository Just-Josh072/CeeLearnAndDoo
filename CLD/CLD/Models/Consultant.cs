using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Consultant
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public char ImageUrl { get; set; }
        public char Biography { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }
    }

    public class ConsultantExpertise
    {
        public int ConsultantId { get; set; }
        public int ExpertiseId { get; set; }
    }

    public class Expertise
    {
        public int Id { get; set; }
        public char Name { get; set; }


    }
}
