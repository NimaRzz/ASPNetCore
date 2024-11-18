using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repository.Office
{
    public interface IOfficeRepository
    {
        bool IsUnique(long Id);

        void AddOffice(Entities.Offices.Office office);

        void SaveOffice();
    }
}
