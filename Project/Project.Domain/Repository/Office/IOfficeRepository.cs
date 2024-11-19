using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Province;

namespace Project.Domain.Repository.Office
{
    public interface IOfficeRepository
    {
        Task<bool> IsUnique(long Id);

        //Task<Province> SearchProvince(long Id);

        Task AddOffice(Entities.Offices.Office office);

        Task UpdateOffice(Entities.Offices.Office office);

        Task SaveOfficeAsync();

    }
}
