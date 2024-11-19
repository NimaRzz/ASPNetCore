using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Province;
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

        public async Task<bool> IsUnique(long Id)
        {
            var office = await _context.Offices.FirstOrDefaultAsync(x => x.Id == Id);
            if (office != null)
            {
                return false;
            }
            return true;
        }


        public async Task AddOffice(Domain.Entities.Offices.Office office)
        {
           await _context.AddAsync(office);
        }

        public async Task UpdateOffice(Domain.Entities.Offices.Office office)
        {


        }

        public async Task SaveOfficeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
