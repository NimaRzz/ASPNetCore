using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using System.Text.RegularExpressions;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Domain.Repository.Plan;
using Project.Application.Services.Plans.Commands.DTOs;

namespace Project.Application.Common.Validations.Plan
{
    public class OfficePlanValidator
    {
        public static async Task<ResultDto> ValidateRequest(object request, IPlanRepository repository)
        {

            if (!await repository.IsExists<Domain.Entities.Offices.Office>(request))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "این دفتر ثبت نشده"
                };
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }
    }
}
