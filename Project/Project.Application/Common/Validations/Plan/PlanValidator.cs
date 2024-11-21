//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


using Project.Domain.Common.Dto;
using System.Text.RegularExpressions;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Domain.Repository.Plan;

namespace Project.Application.Common.Validations.Plan
{
    public class PlanValidator
    {
        public static async Task<ResultDto> ValidateOfficeRequest(object request, IPlanRepository repository)
        {
            ResultDto result = new ResultDto()
            {
                IsSuccess = true
            };

            // بررسی اینکه آیا شماره دفتر وارد شده است یا نه
            //if (request is  )
            //{
                //result = await ValidateRequest(updateRequest.Id, updateRequest.Name, updateRequest.ProvinceId, updateRequest.Address, repository);
            //}
            if (request is OfficePlanDto addRequest2)
            {
                result = await ValidateRequest(addRequest2.Capacity, addRequest2.OfficeId, repository);
            }
            return result;
        }

        private static async Task<ResultDto> ValidateRequest(int capacity, string officeId, IPlanRepository repository)
        {
            // بررسی اینکه شماره دفتر وارد شده باشد

            
            if (capacity<= 0)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ظرفیت طرح باید بیشتر از 0 باشد"
                };
            }

            if (!await repository.IsExists<Domain.Entities.Offices.Office>(officeId))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "این دفتر ثبت نشده "
                };
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }
    }
}
