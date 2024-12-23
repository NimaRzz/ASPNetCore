using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Commands.DTOs;
using Project.Domain.Common.Dto;

namespace Project.Application.Common.Validations.Citizen
{
    public static class CitizenValidator
    {
        public static async Task<ResultDto> ValidateRequest(CitizenCommandsDto request)
        {

            if(string.IsNullOrEmpty(request.Name) || request.HouseholdCode == 0 || request.UniqueCode == 0 || request.PassportCode == 0 || request.PersonalizedCode == 0 )
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "لطفا تمامی اطلاعات خواسته شده را تکمیل کنید"
                };
            }
            return new ResultDto
            {
                IsSuccess = true
            };
        }
    }
}
