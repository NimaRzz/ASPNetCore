using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Turns;

namespace Project.Domain.Entities.Citizens
{
    public class Citizen:BaseEntity.BaseEntity
    {

        public string Name { get; set; }

        public long HouseholdCode { get; set; }

        public long UniqueCode { get; set; }

        public long PassportCode { get; set; }

        public long PersonalizedCode { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
