using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Presentation.Areas.Admin.Models.DTOs.Citizen;

namespace Project.Presentation.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly ICitizenFacad _citizenFacad;
        public CitizensController(ICitizenFacad citizenFacad) 
        {
            _citizenFacad = citizenFacad;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CitizenDto request)
        {
            var result = await _citizenFacad.AddCitizenService.Execute(new RequestAddCitizenDto()
            {
                Name = request.Name,
                HouseholdCode = request.HouseholdCode,
                UniqueCode = request.UniqueCode,
                PassportCode = request.PassportCode,
                PersonalizedCode = request.PersonalizedCode
            });

            return Ok(result);
        }
    }
}
