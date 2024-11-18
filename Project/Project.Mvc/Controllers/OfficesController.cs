using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;

namespace Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficeFacad _officeFacad;

        public OfficesController(IOfficeFacad officeFacad)
        {
            _officeFacad = officeFacad;
        }
    }


}
