using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public string Biography { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }
    }

    public class ConsultantExpertise
    {
        public Expertise Expertise { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        public int ExpertiseId { get; set; }
    }

    public class Expertise
    {
        public int Id { get; set; }
        public char Name { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }
    

}
}
