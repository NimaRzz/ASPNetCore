using Project.Application.Services.Plans.Commands.DTOs;

namespace Project.Mvc.Areas.Admin.Models.DTOs.Plan
{
    public class PlanDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public DateTime StartPlan { get; set; }

        public DateTime EndPlan { get; set; }

        public ICollection<PlanCommandsOfficePlanDto> OfficePlan { get; set; }
    }
}
