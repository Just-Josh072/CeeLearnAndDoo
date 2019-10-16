using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Article
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
        public bool IsVisible { get; set; }
        public ICollection<ArticleComment> ArticleComment { get; set; }
    }

    public class ArticleComment
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public User User { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}