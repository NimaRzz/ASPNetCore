using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Domain.Entities.Province;

namespace Project.Application.Services.Offices.Commands.AddOffice
{
    public class AddOfficeService:IAddOfficeService
    {
        private readonly IOfficeRepository _repository;

        public AddOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddOfficeDto request)
        {
            
         var validationResult = await OfficeValidator.ValidateOfficeRequest(request, _repository);

         if (!validationResult.IsSuccess)
         {
             return validationResult;
         }

         // بررسی یکتایی شماره دفتر
         if (!await _repository.IsUnique(request.Id))
         {
             return new ResultDto
             {
                 IsSuccess = false,
                 Message = "این شماره قبلا ثبت شده"
             };
         }

            //var province = (Province)request.Province;

            Office office = new()
            {
                Id = request.Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
            };

           await _repository.AddOffice(office); 
           await _repository.SaveOfficeAsync();


            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت افزوده شد"
            };
        }
    }
}
