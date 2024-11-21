using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Application.Services.Offices.Queries.GetOffices;
using Project.Domain.Entities.Offices;
using Project.Mvc.Areas.Admin.Models.DTOs.Common.Pagination;
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
        public async Task<IActionResult> Delete([FromBody] string Id)
        {

            var result = await _officeFacad.DeleteOfficeService.Execute(Id);

            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> Get([FromBody] string Id)
        {

            var result = await _officeFacad.GetOfficeService.Execute(Id);

            return Ok(result);
        }

        [HttpPost("getall")]
        public async Task<IActionResult> Get([FromBody] Pagination request)
        {

            var result = await _officeFacad.GetOfficesService.Execute(new RequestGetOffices
            {
                PageSize = request.PageSize,
                Page = request.Page,
            });

            return Ok(result);
        }
    }
}


