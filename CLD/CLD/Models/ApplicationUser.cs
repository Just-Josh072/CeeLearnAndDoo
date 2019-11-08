using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime CreationDate { get; set; }
        public ApplicationUser()
        {
            CreationDate = DateTime.Now;
        }
        public ICollection<Question> Question { get; set; }
        public ICollection<ArticleComment> ArticleComment { get; set; }
        
    }
}
