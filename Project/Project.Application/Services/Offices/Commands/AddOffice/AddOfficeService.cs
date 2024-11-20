using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Domain.Entities.Province;
using Project.Application.Common.Validations.Common;

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
            long id = Convert.ToInt64(request.Id);
          
            var idCheckerResult = await BigIdChecker.IsBig(id);

           if (idCheckerResult)
           {
               return new ResultDto()
               {
                   IsSuccess = false,
                   Message = "شماره دفتر باید کوچک تر از 100 باشد"
               };
            }

            var existsResult = await _repository.IsExists<Office>(request.Id);

            if (existsResult)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود دارد"
                };
            }

            var validationResult = await OfficeValidator.ValidateOfficeRequest(request, _repository);

         if (!validationResult.IsSuccess)
         {
             return validationResult;
         }

         string Id = null;

         if (request.ProvinceId < 10 && id < 10)
         {
             Id = $"0{request.ProvinceId}0{id}";
         }
         else if (request.ProvinceId >= 10 && id >= 10)
         {
             Id = $"{request.ProvinceId}{id}";
         }
         else if (request.ProvinceId < 10 && id >= 10)
         {
             Id = $"0{request.ProvinceId}{id}";
         }
         else if (request.ProvinceId >= 10 && id < 10)
         {
             Id = $"{request.ProvinceId}0{id}";
         }


            Office office = new()
            {
                Id = Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
            };

           await _repository.Add(office);
           await _repository.SaveAsync();


            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت افزوده شد"
            };
        }
    }
}
