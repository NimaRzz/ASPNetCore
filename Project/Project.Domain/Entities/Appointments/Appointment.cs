using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Appointments;
using Project.Domain.Entities.Citizens;
using Project.Domain.Entities.Plans;

namespace Project.Domain.Entities.Turns
{
    public class Appointment:BaseEntity.BaseEntity
    {

        // تاریخ و ساعت نوبت
        public DateTime AppointmentDate { get; set; }

        // وضعیت نوبت (آزاد یا رزرو شده)
        public AppointmentStatus Status { get; set; }

        // اطلاعات کاربری که نوبت را رزرو کرده
        public long CitizenId { get; set; }

        public Citizen Citizen { get; set; }

        // اطلاعات سرویس یا کاری که برای آن نوبت رزرو شده
        public string PlanId { get; set; }

        public Plan Plan { get; set; }

    }
}
