using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
        public class ClosedAnswer
        {
            public int Id { get; set; }
            public string Answer { get; set; }
            public bool Answered { get; set; }

            public Question Question { get; set; }
    }
}
