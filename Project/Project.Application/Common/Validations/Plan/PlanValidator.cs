using Project.Domain.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Application.Common.Validations.Common;
using System.Text.RegularExpressions;

namespace Project.Application.Common.Validations.Plan
{
    public class PlanValidator
    {
        public static async Task<ResultDto> ValidateRequest(RequestAddPlanDto request)
        {
            if (string.IsNullOrEmpty(request.Id))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شناسه طرح را وارد کنید"
                };
            }

                await BigIdChecker.IsBig(request.Id);
                
            string pattern = @"^[\u0600-\u06FF0-9]+$";
            if (!Regex.IsMatch(request.Name, pattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "فقط حروف فارسی و اعداد مجاز هستند."
                };
            }

            if (request.Capacity <= 0)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ظرفیت طرح باید بیشتر از 0 باشد"
                };
            }

            if (request.StartPlan >= request.EndPlan)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "تاریخ پایان طرح باید بعد از تاریخ شروع طرح باشد"
                };
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }
    }
}
