using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Repository.Plan;
using Project.Application.Interfaces.Plans;
using Project.Domain.Common.Dto;
using Project.Application.Common.Validations.Plan;
using Project.Domain.Entities.Plans;
using System.Numerics;
using Project.Domain.Entities.Offices;

namespace Project.Application.Services.Plans.Commands.UpdatePlan
{
    public class UpdatePlanService:IUpdatePlanService
    {

        private readonly IPlanRepository _repository;

        public UpdatePlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto> Execute(RequestUpdatePlanDto request)
        {

            var existsResult = await _repository.IsExists<Plan>(request.Id);

            if (!existsResult)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "طرحی با این شناسه وجود ندارد"
                };
            }

            var planValidateResult = await PlanValidator.ValidatePlanRequest(request);

            if (!planValidateResult.IsSuccess)
            {
                return planValidateResult;
            }

            Plan plan = new()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan
            };

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
                        PlanId = request.Id

                    });
                }

            await _repository.Update<Plan>(plan);
            await _repository.SaveAsync();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "طرح با موفقیت اپدیت شد"
            };

        }
    }
}
