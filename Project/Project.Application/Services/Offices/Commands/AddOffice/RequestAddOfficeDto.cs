using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Province;

namespace Project.Application.Services.Offices.Commands.AddOffice
{
    public class RequestAddOfficeDto
    {
        public long Id { get; set; }
        
        [RegularExpression(@"^[\u0600-\u06FF0-9]+$", ErrorMessage = "فقط حروف فارسی و اعداد مجاز هستند.")]
        public string Name { get; set; }

        public Province Province { get; set; }
    }

}
