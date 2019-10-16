using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
        public string Biography { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }
    }

    public class ConsultantExpertise
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public Expertise Expertise { get; set; }
        public int ExpertiseId { get; set; }
    }

    public class Expertise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }


    }
}
