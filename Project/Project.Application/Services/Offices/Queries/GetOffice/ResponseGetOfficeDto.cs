using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Offices.Queries.GetOffice
{
    public class ResponseGetOfficeDto
    {
        public long Id { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public string Province { get; set; }

    }
}
