using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Interfaces.Offices;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Application.Services.Offices.Commands.DeleteOffice;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Domain.Repository.Office;

namespace Project.Application.Services.Offices.FacadPattern
{
    public class OfficeFacad:IOfficeFacad
    {
        private readonly IOfficeRepository _repository;

        public OfficeFacad(IOfficeRepository repository)
        {
            _repository = repository;
        }

        private IAddOfficeService _addOfficeService;

        public IAddOfficeService AddOfficeService
        {
            get
            {
                return _addOfficeService = _addOfficeService ?? new AddOfficeService(_repository);
            }
        }

        private IUpdateOfficeService _updateOfficeService;

        public IUpdateOfficeService UpdateOfficeService
        {
            get
            {
                return _updateOfficeService = _updateOfficeService ?? new UpdateOfficeService(_repository);
            }
        }

        private IDeleteOfficeService _deleteOfficeService;

        public IDeleteOfficeService DeleteOfficeService
        {
            get
            {
                return _deleteOfficeService = _deleteOfficeService ?? new DeleteOfficeService(_repository);
            }
        }
    }
}
