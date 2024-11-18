using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Appointments
{
    public enum AppointmentStatus
    {
        Available,  // نوبت آزاد
        Reserved,   // نوبت رزرو شده
        Cancelled,  // نوبت لغو شده
        Completed   // نوبت تکمیل شده
    }
}
