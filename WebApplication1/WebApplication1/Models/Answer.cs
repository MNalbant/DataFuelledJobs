using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public ClosedAnswer ClosedAnswers { get; set; }
        public OpenAnswer OpenAnswer { get; set; }
    }

    public class ClosedAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Answered { get; set; }

    }

    public class OpenAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool OAnswer { get; set; }
    }
}
