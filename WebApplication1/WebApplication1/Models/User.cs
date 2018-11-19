using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Phone { get; set; }
        public Address Address { get; set; }
        public List<SurveyUser> SurveyUsers { get; set; }

    }
}
