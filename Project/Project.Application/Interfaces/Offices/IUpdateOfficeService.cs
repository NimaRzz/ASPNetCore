using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Services.Offices.Commands.UpdateOffice;

namespace Project.Application.Interfaces.Offices
{
    public interface IUpdateOfficeService
    {
        Task<ResultDto> Execute(RequestUpdateOfficeDto request);
    }
}
