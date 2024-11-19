using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Application.Common.Validations.Office;
using Project.Application.Interfaces.Offices;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.Commands.DeleteOffice
{
    public class DeleteOfficeService:IDeleteOfficeService
    {

        private readonly IOfficeRepository _repository;

        public DeleteOfficeService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(long Id)
        {
            var existsOffice = await OfficeExistsChecker.ExistsOffice(Id, _repository);

            if (!existsOffice)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دفتری با این شماره وجود ندارد"
                };
            }

                await _repository.DeleteOffice(Id);
                await _repository.SaveOfficeAsync();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "دفتر با موفقیت حذف شد"
                };
                
        }
    }
}
