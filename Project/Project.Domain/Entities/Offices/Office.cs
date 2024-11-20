using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Citizens;


namespace Project.Domain.Entities.Offices
{
    public class Office:BaseEntity.BaseEntity<string>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string? NewId { get; set; }

        public byte[] RowVersion { get; set; } // فیلد همزمانی

        public Province.Province Province { get; set; }

        public long ProvinceId { get; set; }

        public ICollection<OfficePlan> OfficePlans { get; set; }

        public IEnumerable<WorkCalendar> WorkCalendars { get; set; }

        public ICollection<Citizen> Citizens { get; set; }

    }
}
