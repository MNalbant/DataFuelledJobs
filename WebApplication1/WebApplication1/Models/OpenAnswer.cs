using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OpenAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string GivenAnswer { get; set; }

        [ForeignKey("Question")]
        public Question question { get; set; }
    }
}
