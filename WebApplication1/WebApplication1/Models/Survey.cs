using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Comapny { get; set; }
        public Person Person { get; set; }
        public List<Question> Questions { get; set; }
    }
}
