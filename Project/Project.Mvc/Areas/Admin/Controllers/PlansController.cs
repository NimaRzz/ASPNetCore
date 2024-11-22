using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Mvc.Areas.Admin.Models.DTOs.Plan;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Domain.Entities.Offices;

namespace Project.Mvc.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private readonly IPlanFacad _planFacad;

        public PlansController(IPlanFacad planFacad)
        {
            _planFacad = planFacad;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] PlanDto request)
        {
            var result = await _planFacad.AddPlanService.Execute(new RequestAddPlanDto()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan,
                OfficePlan = request.OfficePlan,
            });

            return Ok(result);
        }
    }
}
