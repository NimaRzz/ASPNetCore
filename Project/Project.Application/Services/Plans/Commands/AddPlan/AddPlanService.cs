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
using Project.Application.Common.Validations.Plan;
using Project.Application.Common.GenerateId;

namespace Project.Application.Services.Plans.Commands.AddPlan
{
    public class AddPlanService : IAddPlanService
    {

        private readonly IPlanRepository _repository;

        public AddPlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestAddPlanDto request)
        {

            var idChecker = await BigIdChecker.IsBig<string>(request.Id);

            if (!idChecker.IsSuccess)
            {
                return idChecker;
            }

            var existsResult = await _repository.IsExists<Plan>(request.Id);
            if (existsResult)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "این طرح قبلا ثبت شده"
                };
            }

            var planValidateResult = await PlanValidator.ValidateRequest(request);

            if (!planValidateResult.IsSuccess)
            {
                return planValidateResult;
            }

            string officeIdValue = request.OfficePlan.FirstOrDefault().OfficeId;
           

            var planId = await CustomIdGenerator.GenerateId<string, string>(officeIdValue.Substring(2,4), request.Id);
           
            Plan plan = new()
            {
                Id = planId,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan
            };

            await _repository.Add<Plan>(plan);
            await _repository.SaveAsync();

            List<OfficePlan> officePlan = new();
            var officeId = request.OfficePlan.FirstOrDefault();
                var officePlanValidatorResult = await OfficePlanValidator.ValidateRequest(officeId, _repository);
                if (!officePlanValidatorResult.IsSuccess)
                {
                    return officePlanValidatorResult;
                }
                var office = await _repository.Get<Office>(officeId.OfficeId);

                if (office != null)
                {
                    officePlan.Add(new OfficePlan()
                    {
                        OfficeId = officeId.OfficeId,
                        Plan = plan,
                        PlanId = planId

                    });
                }

            plan.OfficePlans = officePlan;
            await _repository.Add<OfficePlan>(officePlan.FirstOrDefault());
            await _repository.SaveAsync();



            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت افزوده شد"
            };
        }
    }
}
