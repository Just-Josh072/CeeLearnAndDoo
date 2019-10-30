using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int CategoryId { get; set; }
        public char ArticleTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public char Content { get; set; }
        public bool IsVisible { get; set; }
        public ICollection<ArticleComment> ArticleComment { get; set; }
    }

    public class ArticleComment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public char Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}