using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OpenAnswer
    {
        public int Id { get; set; }
        [Required]
        public string _OpenAnswer { get; set; }
        [Required]
        public string UserResponse { get; set; }

        [ForeignKey("Question")]
        public Question question { get; set; }
    }
}
