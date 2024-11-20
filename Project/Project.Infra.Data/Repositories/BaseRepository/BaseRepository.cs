using Project.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Common.Dto;

namespace Project.Infra.Data.Repositories.BaseRepository
{
    public class BaseRepository: IBaseRepository
    {
        private readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<bool> IsExists<T>(long Id) where T : class
        {
            // استفاده از یک DbSet عمومی
            var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == Id);
           
            if (entity != null)
            {
                return true;
            }
            return false;
        }

        public async Task<ResultDto<T>> Get<T>(long Id) where T : class
        {

            var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == Id);

            if (entity != null)
            {
                return new ResultDto<T>()
                {
                    Data = entity,
                    IsSuccess = true
                };
            }
            return new ResultDto<T>()
            {
                Data = entity,
            };
        }

        public async Task Add(object Object)
        {
            await _context.AddAsync(Object);
        }

        public async Task Update<T>(object Object) where T : class
        {

            if (Object != null)
            {
                
                var entry = _context.Entry(Object);

                entry.CurrentValues.SetValues(Object);

                entry.State = EntityState.Modified;

                entry.Property("InsertTime").IsModified = false;

            }
            
        }

        public async Task Delete<T>(object Object) where T : class
        {

            if (Object != null)
            {
                var property = Object.GetType().GetProperty("IsRemoved");
                if (property != null)
                {
                    property.SetValue(Object, true);
                    _context.Entry(Object).State = EntityState.Modified;
                }
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
