using Project.Domain.Entities.Province;

namespace Project.Mvc.Areas.Admin.Models.DTOs.Office
{
    public class OfficeDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long ProvinceId { get; set; }

        public string Address { get; set; }
    }
}
