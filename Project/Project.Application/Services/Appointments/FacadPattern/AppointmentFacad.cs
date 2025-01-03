using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Appointments;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Domain.Repository.Appointment;

namespace Project.Application.Services.Appointments.FacadPattern
{
    public class AppointmentFacad: IAppointmentFacad
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentFacad(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        private IAddAppointmentService _addAppointmentService;

        public IAddAppointmentService AddAppointmentService
        {
            get
            {
                return _addAppointmentService = _addAppointmentService ?? new AddAppointmentService(_repository);
            }
        }
    }
}
