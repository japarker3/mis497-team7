using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuth.Models
{
    public class Athlete
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}