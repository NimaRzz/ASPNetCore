﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Plans.Commands.DTOs
{
    public class PlanCommandsDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public DateTime StartPlan { get; set; }

        public DateTime EndPlan { get; set; }

        public ICollection<PlanCommandsOfficePlanDto> OfficePlan { get; set; }
    }
}
