using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Offices;

namespace Project.Application.Services.Offices.Queries.DTOs
{
    public class OfficeQueriesDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Province { get; set; }

        public List<DaysOfTheWeek> Workdays { get; set; }

        public List<DaysOfTheWeek> Holidays { get; set; }


    }
}
