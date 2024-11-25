using Project.Application.Services.Offices.Commands.DTOs;

namespace Project.Mvc.Areas.Admin.Models.DTOs.Office
{
    public class OfficeDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long ProvinceId { get; set; }

        public string Address { get; set; }

        public List<OfficeWorkCalendarCommandsDto> Workdays { get; set; }
    }
}
