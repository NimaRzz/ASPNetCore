using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Services.Offices.Commands.AddOffice;

namespace Project.Application.Interfaces.Offices
{
    public interface IAddOfficeService
    {
        ResultDto AddOffice(RequestAddOfficeDto request);
    }
}
