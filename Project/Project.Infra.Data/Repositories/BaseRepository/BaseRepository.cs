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

        public virtual async Task<bool> IsExists<T>(long Id) where T : class
        {
            // استفاده از یک DbSet عمومی
            var entity = await _context.Set<T>().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == Id);
           
            if (entity != null)
            {
                return true;
            }
            return false;
        }
    }
}
