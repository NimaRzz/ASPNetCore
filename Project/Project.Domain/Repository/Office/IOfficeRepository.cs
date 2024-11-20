using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;

namespace Project.Domain.Repository.Office
{
    public interface IOfficeRepository:IBaseRepository
    {
        Task<Province> SearchProvince(long ProvinceId);
    }
}
