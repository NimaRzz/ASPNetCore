using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Interfaces.Offices;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;


namespace Project.Application.Services.Offices.Commands.AddOffice
{
    public class AddOfficeService:IAddOfficeService
    {
        private readonly IOfficeRepository _repository;

        public AddOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public ResultDto AddOffice(RequestAddOfficeDto request)
        {

            if (string.IsNullOrEmpty(request.Name))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "نام دفتر را وارد کنید"
                };
            }

            if (request.Id == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شماره دفتر را وارد کنید"
                };
            }

            if (_repository.IsUnique(request.Id))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "این ایدی قبلا ثبت شده"
                };
            }

            Office office = new()
            {
                Id = request.Id,
                Name = request.Name,
                Province = request.Province
            };

            _repository.AddOffice(office);

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دفتر با موفقیت افزوده شد"
            };
        }
    }
}
