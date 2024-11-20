using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Province;


namespace Project.Application.Services.Offices.Commands.AddOffice
{
    public class RequestAddOfficeDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long ProvinceId { get; set; }

        public string Address { get; set; }
    }

}
