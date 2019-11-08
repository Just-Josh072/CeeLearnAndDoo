using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public Consultant Consultant { get; set; }
        public int QuestionId { get; set; }
        public int ConsultantId { get; set; }
        public string AnswerContent { get; set; }
    }
}
