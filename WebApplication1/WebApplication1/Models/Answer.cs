using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public Question Question { get; set; }
        public List<ClosedAnswer> ClosedAnswers { get; set; }
        public OpenAnswer OpenAnswer { get; set; }

    }
}
