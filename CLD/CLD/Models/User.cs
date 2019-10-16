using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [get: System.Security.SecurityCritical]
        [set: System.Security.SecurityCritical]
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<ArticleComment> ArticleComment { get; set; }
        public ICollection<Consultant> Consultant { get; set; }


    }
}
