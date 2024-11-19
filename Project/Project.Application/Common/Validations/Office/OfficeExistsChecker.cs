using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Dto;
using Project.Domain.Repository.Office;

namespace Project.Application.Common.Validations.Office
{
    class OfficeExistsChecker
    {
        public static async Task<bool> ExistsOffice(long Id, IOfficeRepository _repository)
        {
            if (await _repository.IsExists<Domain.Entities.Offices.Office>(Id))
            {
                return true;
            }

            return false;
        }
    }
}
