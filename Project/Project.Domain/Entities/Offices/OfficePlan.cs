using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Plans;

namespace Project.Domain.Entities.Offices
{
    public class OfficePlan:BaseEntity.BaseEntity
    {

        public int Capacity { get; set; }
        
        public TimeSpan WorkStart { get; set; }
       
        public TimeSpan WorkEnd { get; set; }

        public Office Office { get; set; }
        
        public long OfficeId { get; set; }

        public Plan Plan { get; set; }

        public long PlanId { get; set; }


    }
}
