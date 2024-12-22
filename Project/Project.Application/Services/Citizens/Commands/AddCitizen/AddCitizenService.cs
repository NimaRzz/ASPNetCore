using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.Commands.AddCitizen
{
    public class AddCitizenService : IAddCitizenService
    {
        private readonly ICitizenRepository _repository;
        public AddCitizenService(ICitizenRepository repository) 
        {
        
            _repository = repository;
        
        }


        public async Task<ResultDto> Execute(RequestAddCitizenDto request)
        {




            return new ResultDto
            {
                IsSuccess = true,
                Message = "تبعه با موفقیت افزوده شد"
            };
        }
    }
}
