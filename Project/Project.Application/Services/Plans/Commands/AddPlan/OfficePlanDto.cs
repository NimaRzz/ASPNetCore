using Project.Domain.Entities.Offices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Plans.Commands.AddPlan
{
    public class OfficePlanDto
    {

        public int Capacity { get; set; }

        public string OfficeId { get; set; }
    }
}
