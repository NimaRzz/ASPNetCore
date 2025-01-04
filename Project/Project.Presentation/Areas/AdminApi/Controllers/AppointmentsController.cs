using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Domain.Entities.Users;
using Project.Presentation.Areas.AdminApi.Models.DTOs.Appointments;

namespace Project.Presentation.Areas.AdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentFacad _appointmentFacad;

        private readonly UserManager<User> _userManager;


        public AppointmentsController(IAppointmentFacad appointmentFacad, ICitizenFacad citizenFacad, IPlanFacad planFacad, UserManager<User> userManager)
        {
            _appointmentFacad = appointmentFacad;

            _userManager = userManager;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(AppointmentDto request) {

            var result = await _appointmentFacad.AddAppointmentService.Execute(new RequestAddAppointmentDto
            {
                AppointmentDateStart = request.AppointmentDateStart,
                AppointmentDateEnd = request.AppointmentDateEnd,
                CitizenId = request.CitizenId,
                PlanId = request.PlanId,
                AdminId = _userManager.GetUserId(User)

            });

            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(long Id)
        {

            var result = await _appointmentFacad.DeleteAppointmentService.Execute(Id);

            return Ok(result);
        }
    }
}
