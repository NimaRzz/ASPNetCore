using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;

namespace Project.Infra.Data.Repositories.Office
{
    public class OfficeRepository: BaseRepository.BaseRepository, IOfficeRepository
    {
        private readonly DataBaseContext _context;

        public OfficeRepository(DataBaseContext context):base(context)
        {
            _context = context;
        }

        public async Task<bool> IsExists<T>(long Id) where T : class
        {
            return await base.IsExists<T>(Id);
        }


        public async Task Add(Domain.Entities.Offices.Office office)
        {
            await base.Add(office);
        }

        public async Task Update<T>(Domain.Entities.Offices.Office office) where T : class
        {

            await base.Update<T>(office);
            
        }

        public async Task DeleteOffice(long Id)
        {
          var office = await _context.Offices.FirstOrDefaultAsync(c => c.Id == Id);
          office.IsRemoved = true;
          office.RemoveTime = DateTime.Now;
        }

        public async Task SaveOfficeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
