using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Application.Services.Offices.Commands.UpdateOffice;
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

            var existsOffice = await OfficeExistsChecker.ExistsOffice(request.Id, _repository);

            if (!existsOffice)
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

            Office office = new()
            {
                Id = request.Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
            };

            await _repository.Update<Office>(office);
            await _repository.SaveOfficeAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت اپدیت شد"
            };
        }

    }
}
