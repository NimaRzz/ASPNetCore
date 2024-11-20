using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Offices;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.Queries.GetOffice
{
    public class GetOfficeService:IGetOfficeService
    {

        private readonly IOfficeRepository _repository;

        public GetOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResponseGetOfficeDto>> Execute(string Id)
        {
            var office = await _repository.Get<Office>(Id);

            if (office.Data == null)
            {
                return new ResultDto<ResponseGetOfficeDto>()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره دفتر وجود ندارد"
                };
            }
          
            return new ResultDto<ResponseGetOfficeDto>()
            {
                Data = new ResponseGetOfficeDto()
                {
                    Id = Id,
                    Address = office.Data.Address,
                    Name = office.Data.Name,
                    Province = (await _repository.SearchProvince(office.Data.ProvinceId)).Name
                },
                IsSuccess = true
            };
        }
    }
}
