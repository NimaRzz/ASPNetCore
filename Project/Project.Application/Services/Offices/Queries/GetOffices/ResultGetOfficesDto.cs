using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.Offices.Queries.GetOffices
{
    public class ResultGetOfficesDto
    {
       public List<GetOffices> Offices { get; set; }

       public int TotalPages { get; set; }
    }
}
