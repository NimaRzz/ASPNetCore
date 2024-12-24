using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Application.Services.Citizens.Commands.UpdateCitizen;
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

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCitizenDto request)
        {
            var result = await _citizenFacad.UpdateCitizenService.Execute(new RequestUpdateCitizenDto()
            {
                Name = request.Name,
                UniqueCode = request.UniqueCode
            });

            return Ok(result);
        }
        
        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] long UniqueCode)
        {
            var result = await _citizenFacad.DeleteCitizenService.Execute(UniqueCode);
         

            return Ok(result);
        }

    }
}
