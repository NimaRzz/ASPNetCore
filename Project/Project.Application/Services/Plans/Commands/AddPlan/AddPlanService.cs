using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Plans;
using Project.Domain.Repository.Plan;
using Project.Application.Interfaces.Plans;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Plans;
using Project.Domain.Entities.Offices;
using Project.Application.Common.Validations.Common;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Project.Application.Services.Plans.Commands.AddPlan
{
    public class AddPlanService:IAddPlanService
    {

        private readonly IPlanRepository _repository;

        public AddPlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddPlanDto request)
        {

            long id = Convert.ToInt64(request.Id);

            var idCheckerResult = await BigIdChecker.IsBig(id);

            if (idCheckerResult)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شناسه طرح باید کوچک تر از 100 باشد"
                };
            }

            string pattern = @"^[\u0600-\u06FF0-9]+$";
            if (!Regex.IsMatch(request.Name, pattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "فقط حروف فارسی و اعداد مجاز هستند."
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


            if (string.IsNullOrEmpty(request.Id))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شناسه پلن را وارد کنید"
                };
            }


            Plan plan = new()
            {
                Id = request.Id,
                Name = request.Name,
                OfficePlans = request.OfficePlans,
            };

            _repository.Add<Plan>(plan);
            _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت افزوده شد"
            };
        }
    }
}
