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
using Project.Application.Common.Converter;

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

            var existsResult = await _repository.Get<Office>(request.Id);

            if (!existsResult.IsSuccess)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود ندارد"
                };
            }

            List<WorkCalendar> workCalendar = new();

            foreach (var item in request.Workdays)
            {
                var workStart = await ConvertToTimeSpan.Converter(item.WorkStart);
                var workEnd = await ConvertToTimeSpan.Converter(item.WorkEnd);
                if (!workStart.IsSuccess)
                {
                    return workStart;
                }
                if (!workEnd.IsSuccess)
                {
                    return workStart;
                }

                WorkCalendar wc = new()
                {
                    Workday = item.Workday,
                    WorkStart = workStart.Data,
                    WorkEnd = workEnd.Data,
                };

                workCalendar.Add(wc);
            }


            var validationResult = await OfficeValidator.ValidateOfficeRequest(request);

            if (!validationResult.IsSuccess)
            {
                return validationResult;
            }


            
        

            Office office = new()
            {
                Id = request.Id,
                Name = request.Name,
                ProvinceId = existsResult.Data.ProvinceId,
                Address = request.Address,
                WorkCalendars = workCalendar
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
