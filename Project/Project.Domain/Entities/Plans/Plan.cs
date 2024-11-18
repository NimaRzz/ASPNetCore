using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Turns;

namespace Project.Domain.Entities.Plans
{
    public class Plan:BaseEntity.BaseEntity
    {
        public string Name { get; set; }

        public ICollection<OfficePlan> OfficePlans { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
