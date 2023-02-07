using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LearningManagement.Models
{
    public class Assignments
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal TotalAvaliablePoints { get; set; }
        public DateTime DueDate { get; set; }
    }
}
