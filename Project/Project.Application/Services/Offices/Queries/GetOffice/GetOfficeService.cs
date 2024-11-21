using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Provinces;
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

        public async Task<ResultDto<ResultGetOfficeDto>> Execute(string Id)
        {
            var office = await _repository.Get<Office>(Id);

            if (office.Data == null)
            {
                return new ResultDto<ResultGetOfficeDto>()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره دفتر وجود ندارد"
                };
            }
            var provinceId = office.Data.ProvinceId;

            string province = Enum.GetName(typeof(ProvincesEnum), provinceId);
            return new ResultDto<ResultGetOfficeDto>()
            {
                Data = new ResultGetOfficeDto()
                {
                    Id = Id,
                    Address = office.Data.Address,
                    Name = office.Data.Name,
                    Province = province
                },
                IsSuccess = true,
                Message = "دفتر با موفقیت دریافت شد"
            };
        }
    }
}
