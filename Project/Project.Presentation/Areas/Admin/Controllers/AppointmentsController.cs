using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Appointments.Commands.AddAppointment;
using Project.Application.Services.Appointments.FacadPattern;
using Project.Application.Services.Citizens.Queries.GetCitizens;
using Project.Application.Services.Plans.Queries.GetPlans;
using Project.Domain.Entities.Users;
using Project.Presentation.Areas.Admin.Models.DTOs.Common.Pagination;
using Project.Presentation.Areas.Admin.Models.ViewModels.AppointmentViewModel;

namespace Project.Presentation.Areas.Admin.Controllers
{
    //[Authorize("AdminOrOperator")]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentFacad _appointmentFacad;

        private readonly ICitizenFacad _citizenFacad;

        private readonly IPlanFacad _planFacad;

        private readonly UserManager<User> _userManager;


        public AppointmentsController(IAppointmentFacad appointmentFacad, ICitizenFacad citizenFacad, IPlanFacad planFacad, UserManager<User> userManager)
        {
            _appointmentFacad = appointmentFacad;

            _citizenFacad = citizenFacad;

            _planFacad = planFacad;

            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("admin/appointments/Add")]
        public async Task<IActionResult> Add(AppointmentViewModel request, Pagination paginationRequest)
        {

            ViewBag.Page = paginationRequest.Page;

            ViewBag.PageSize = paginationRequest.PageSize;

            var citizens = await _citizenFacad.GetCitizensService.Execute(new RequestGetCitizensDto
            {
                Page = paginationRequest.Page,
                PageSize = paginationRequest.PageSize
            });


            var plans = await _planFacad.GetPlansService.Execute(new RequestGetPlansDto
            {
                Page = paginationRequest.Page,
                PageSize = paginationRequest.PageSize
            });

            if (plans.Data.Items != null)
            {
                ViewBag.Plans = new SelectList(plans.Data.Items, "Id", "Name");
            }
            if (citizens.Data.Items != null)
            {
                ViewBag.Citizens = new SelectList(citizens.Data.Items, "Id", "Name");
            }

            return View();
        }


        [HttpPost("admin/appointments/Add")]

        public async Task<IActionResult> Add(AppointmentViewModel request)
        {
            if (ModelState.IsValid)
            {


                var result = await _appointmentFacad.AddAppointmentService.Execute(new RequestAddAppointmentDto()
                {
                    AppointmentDateStart = request.AppointmentDateStart,
                    AppointmentDateEnd = request.AppointmentDateEnd,
                    CitizenId = request.CitizenId,
                    PlanId = request.PlanId,
                    AdminId = _userManager.GetUserId(User)
                });
                if (result.IsSuccess)
                {
                    return Redirect("/admin/users/list");

                }
                else
                {

                    ModelState.AddModelError("", result.Message);
                   
                    return View();
                }
            }
            
            return View();
        }
    }
}
