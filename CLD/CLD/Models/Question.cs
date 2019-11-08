using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public Expertise Expertise { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int UserId { get; set; }
        public int ExpertiseId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public Question()
        {
            CreationDate = DateTime.Now;
        }
        public bool isVisible { get; set; }
        public string Title { get; set; }
        public ICollection<QuestionComment> QuestionComment { get; set; }
    }
    public class QuestionComment
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }

    }
    public class QuestionExpertise
    {
        public Expertise Expertise { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public int ExpertiseId { get; set; }
    }

}
