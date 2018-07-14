using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJob.Model
{
    public class T_Relation_ApplyJob
    {
        public int Id { get; set; }
        public int EnterpriseId { get; set; }
        public string JobName { get; set; }
        public int StudentId { get; set; }
    }
}
