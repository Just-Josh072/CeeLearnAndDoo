using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
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

}
