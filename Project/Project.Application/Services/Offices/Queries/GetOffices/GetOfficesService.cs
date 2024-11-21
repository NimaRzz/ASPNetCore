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

namespace Project.Application.Services.Offices.Queries.GetOffices
{
    public class GetOfficesService:IGetOfficesService
    {

        private readonly IOfficeRepository _repository;

        public GetOfficesService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetOfficesDto>> Execute(RequestGetOffices request)
        {
            Office office = new();
            var offices = await _repository.GetAll<Office>();

            if (offices.IsSuccess == false)
            {
                return new ResultDto<ResultGetOfficesDto>
                {
                    IsSuccess = false,
                    Message = "داده ای یافت نشد"
                };
            }

            int totalPages = (int)Math.Ceiling((double)offices.Data.Count / request.PageSize);

            if (totalPages < request.Page)
            {
                return new ResultDto<ResultGetOfficesDto>()
                {
                    IsSuccess = true,
                    Message = "در این صفحه هیچ دفتری وجود ندارد"
                };
            }

            var returnResult = offices.Data.Skip((request.Page -1) * request.PageSize).Take(request.PageSize).Select((p, index) =>  new GetOffices
            {
                Id = p.Id,
                Name = p.Name,
                Address = p.Address,
                Province = Enum.GetName(typeof(ProvincesEnum), p.ProvinceId)
            }).ToList();
            return new ResultDto<ResultGetOfficesDto>()
            {
                Data = new ResultGetOfficesDto()
                {
                    Offices = returnResult,
                    TotalPages = totalPages
                },
                IsSuccess = true,
                Message = "لیست دفاتر با موفقیت دریافت شد"
            };
        }
    }
}
