using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string _Question { get; set; }
        public List<ClosedAnswer> ClosedAnswers { get; set; }
        public OpenAnswer OpenAnswer { get; set; }

    }
}
