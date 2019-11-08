using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{//  Gemaakt door iemand met Dyslexie *kuch* Joshua *kuch*
    //je moet inloggen als admin #kijkInDe:Seed.cs
    public class Consultant : User
    {
        public int ConsultantId { get; set; }
        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }
        public string GetProfileImageUrl()
        {
            if (string.IsNullOrEmpty(ImageUrl))
            {
                return "http://placehold.it/50x50";
            }
            return ImageUrl;
        }
        [Display(Name = "Omschrijving")]
        public string Biography { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }

    }
    public class ConsultantExpertise
    {
        public Expertise Expertise { get; set; }
        public Consultant Consultant { get; set; }
        public string UserId { get; set; }
        public string ExpertiseId { get; set; }
    }
    public class Expertise
    {
        public string Id { get; set; }
        public string ExpretiseName { get; set; }
        public ICollection<ConsultantExpertise> ConsultantExpertise { get; set; }
    }
}
