using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;

namespace Project.Infra.Data.Repositories.Office
{
    public class OfficeRepository:IOfficeRepository
    {
        private readonly DataBaseContext _context;
        private IOfficeRepository _officeRepositoryImplementation;

        public OfficeRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool IsUnique(long Id)
        {
            var office = _context.Offices.Find(Id);
            if (office != null)
            {
                return false;
            }
            return true;
        }

        public void AddOffice(Domain.Entities.Offices.Office office)
        {
            _context.Add(office);
            SaveOffice();
        }

        public void SaveOffice()
        {
             _context.SaveChanges();
        }
    }
}
