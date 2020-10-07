using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
    }
}
    