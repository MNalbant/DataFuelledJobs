using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
        public class ClosedAnswer
        {
            public int Id { get; set; }
            public string _Answer { get; set; }
            public bool Answered { get; set; }

            public Answer Answer { get; set; }
        }
}
