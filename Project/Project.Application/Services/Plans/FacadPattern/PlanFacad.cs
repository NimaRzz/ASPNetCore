using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.FacadPatterns;
using Project.Domain.Repository.Plan;
using Project.Application.Interfaces.Plans;
using Project.Application.Services.Plans.Commands.AddPlan;

namespace Project.Application.Services.Plans.FacadPattern
{
    public class PlanFacad:IPlanFacad
    {

        private readonly IPlanRepository _repository;

        public PlanFacad(IPlanRepository repository)
        {
            _repository = repository;
        }

        private IAddPlanService _addPlanService;

        public IAddPlanService AddPlanService
        {
            get
            {
                return _addPlanService = _addPlanService ?? new AddPlanService(_repository);
            }
        }
    }
}
