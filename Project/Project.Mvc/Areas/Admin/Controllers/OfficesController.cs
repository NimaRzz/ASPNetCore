using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Domain.Entities.Offices;
using Project.Mvc.Areas.Admin.Models.DTOs.Office;

namespace Project.Mvc.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        
        private readonly IOfficeFacad _officeFacad;

        public OfficesController(IOfficeFacad officeFacad)
        {
            _officeFacad = officeFacad;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] OfficeDto officeDto)
        {

            var result = await _officeFacad.AddOfficeService.Execute(new RequestAddOfficeDto()
            {
                Id = officeDto.Id,
                Name = officeDto.Name,
                ProvinceId = officeDto.ProvinceId,
                Address = officeDto.Address
            });
         

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] OfficeDto officeDto)
        {

            var result = await _officeFacad.UpdateOfficeService.Execute(new RequestUpdateOfficeDto()
            {
                Id = officeDto.Id,
                Name = officeDto.Name,
                ProvinceId = officeDto.ProvinceId,
                Address = officeDto.Address
            });

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] long Id)
        {

            var result = await _officeFacad.DeleteOfficeService.Execute(Id);

            return Ok(result);
        }
    }
}


