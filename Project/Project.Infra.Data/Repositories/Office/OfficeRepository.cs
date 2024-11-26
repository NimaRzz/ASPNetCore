using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;
using Project.Domain.Entities.Offices;

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

        public async Task<ResultDto<T>> Get<T>(long Id) where T : class
        {
            return await base.Get<T>(Id);
        }

        public async Task<ResultDto<List<T>>> GetAll<T>() where T : class
        {
            return await base.GetAll<T>();
        }

        public async Task Add<T>(T Object) where T : class
        {
            await base.Add<T>(Object);
        }

        public async Task AddRange<T>(List<T> Object) where T : class
        {
            await base.AddRange(Object);
        }

        public async Task Update<T>(T Object) where T : class
        {
            await base.Update<T>(Object);
        }

        public async Task Delete<T>(T Object) where T : class
        {
          await base.Delete<T>(Object);
        }
        
        public async Task SaveAsync()
        {
            await base.SaveAsync();
        }

        public async Task<List<WorkCalendar>> GetAllWorkCalendarsAsync(string OfficeId)
        {
          return await _context.WorkCalendars.Where(p => p.OfficeId == OfficeId).ToListAsync();
        }

    }
}
