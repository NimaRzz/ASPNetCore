using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Application.Services.Citizens.Commands.UpdateCitizen;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.FacadPattern
{
    public class CitizenFacad : ICitizenFacad
    {

        private readonly ICitizenRepository _repository;

        public CitizenFacad(ICitizenRepository repository)
        {
            _repository = repository;
        }

        private IAddCitizenService _addCitizenService;

        public IAddCitizenService AddCitizenService
        {
            get
            {
                return _addCitizenService = _addCitizenService ?? new AddCitizenService(_repository);
            }

        }

        private IUpdateCitizenService _updateCitizenService;

        public IUpdateCitizenService UpdateCitizenService
        {
            get
            {

                return _updateCitizenService = _updateCitizenService ?? new UpdateCitizenService(_repository);
            }
        }
    }
}