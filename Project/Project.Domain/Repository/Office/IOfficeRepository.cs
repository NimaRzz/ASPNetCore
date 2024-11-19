using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;

namespace Project.Domain.Repository.Office
{
    public interface IOfficeRepository:IBaseRepository{

        Task AddOffice(Entities.Offices.Office office);

        Task UpdateOffice(Entities.Offices.Office office);
      
        Task DeleteOffice(long Id);

        Task SaveOfficeAsync();

    }
}
