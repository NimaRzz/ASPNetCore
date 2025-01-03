namespace Project.Presentation.Areas.Admin.Models.ViewModels.AppointmentViewModel
{
    public class AppointmentViewModel
    {
        public DateTime AppointmentDateStart { get; set; }

        public DateTime AppointmentDateEnd { get; set; }

        public long CitizenId { get; set; }

        public string PlanId { get; set; }

        public int Page { get; set; } = 1; 
      
        public int PageSize { get; set; } = 20; 
    }
}
