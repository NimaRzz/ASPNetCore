using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.Commands.UpdateOffice
{
    public class UpdateOfficeService:IUpdateOfficeService
    {
        
        private readonly IOfficeRepository _repository;

        public UpdateOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestUpdateOfficeDto request)
        {

            var existsResult = await _repository.IsExists<Office>(request.Id);

            if (!existsResult)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود ندارد"
                };
            }
        
            var validationResult = await OfficeValidator.ValidateOfficeRequest(request, _repository);

            if (!validationResult.IsSuccess)
            {
                return validationResult;
            }

            string Id = request.Id.Remove(0, 2);
           
            if (request.ProvinceId < 10)
            {
                Id = $"0{request.ProvinceId}{Id}";
            }
            else if (request.ProvinceId >= 10)
            {
                Id = $"{request.ProvinceId}{Id}";
            }

            Office office = new()
            {
                Id = request.Id,
                NewId = Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
            };

            await _repository.Update<Office>(office);
            await _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت اپدیت شد"
            };
        }

    }
}
