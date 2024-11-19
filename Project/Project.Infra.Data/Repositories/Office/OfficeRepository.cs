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


        public async Task AddOffice(Domain.Entities.Offices.Office office)
        {
           await _context.AddAsync(office);
        }

        public async Task UpdateOffice(Domain.Entities.Offices.Office office)
        {

            var resultOffice = await _context.Offices.FirstOrDefaultAsync();
            resultOffice.Name = office.Name;
            resultOffice.ProvinceId = office.ProvinceId;
            resultOffice.Address = office.Address;
            resultOffice.Id = office.Id;

            
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
