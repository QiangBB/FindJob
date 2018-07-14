using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJob.Model
{
   public class T_Base_EI
    {
        public int Id { get; set; }
        public Boolean AssociateMajor { get; set; }
        public string Place { get; set; }
        public decimal Salary { get; set; }
        public Boolean SanFang { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }

    }
}
