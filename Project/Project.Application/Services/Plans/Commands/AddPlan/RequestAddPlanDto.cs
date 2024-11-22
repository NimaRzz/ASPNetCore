using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Application.Services.Plans.Commands.AddPlan
{
    public class RequestAddPlanDto
    {
        public string Id { get; set; }
     
        public string Name { get; set; }

        public int Capacity { get; set; }

        public DateTime StartPlan { get; set; }
      
        public DateTime EndPlan { get; set; }

        public ICollection<OfficePlanDto> OfficePlan { get; set; }


    }
}
