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

            var existsResult = await _repository.Get<Plan>(request.Id);

            if (!existsResult.IsSuccess)
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

            var planRowVersion = await _repository.Get<Plan>(request.Id);

            Plan plan = new()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan,
                RowVersion = planRowVersion.Data.RowVersion,
            };


              
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
