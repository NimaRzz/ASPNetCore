using Project.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.BaseRepository;

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
            var entity = await _context.Set<T>().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == Id);
           
            if (entity != null)
            {
                return true;
            }
            return false;
        }

        public async Task Add(object Object)
        {
            await _context.AddAsync(Object);
        }

        public virtual async Task Update<T>(object Object) where T : class
        {
            var setValue = await _context.Set<T>().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == (long)Object.GetType().GetProperty("Id").GetValue(Object));

            if (setValue != null)
            { 
               
                _context.Entry(setValue).CurrentValues.SetValues(Object);

                _context.Entry(setValue).Property("InsertTime").IsModified = false;
            }
            
        }
    }
}
