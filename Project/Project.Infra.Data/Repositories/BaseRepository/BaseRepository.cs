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

        public async Task<bool> IsExists<T>(object Id) where T : class
        {
            T entity = null;
            if (Id is long longId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == longId);
            }

            if (Id is string stringId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<string>(e, "Id") == stringId);
            }

            if (entity != null)
            {
                return true;
            }
            return false;
        }

        public async Task<ResultDto<T>> Get<T>(object Id) where T : class
        {

            T entity = null;
            if (Id is long longId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<long>(e, "Id") == longId);
            }

            if (Id is string stringId)
            {
                entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => EF.Property<string>(e, "Id") == stringId);
            }


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
            };
        }

        public async Task Add(object Object)
        {
            await _context.AddAsync(Object);
        }

        public async Task Update<T>(T Object) where T : class
        {
            if (Object != null)
            {

                var entry = _context.Entry(Object);

                // استخراج RowVersion از رکورد قدیمی
                var rowVersion = entry.Property("RowVersion").CurrentValue;

                if (Object is Domain.Entities.Offices.Office office)
                {

                    if (entry.Property("NewId").CurrentValue != null)
                    {
                        var pkValue = entry.Property("Id").CurrentValue;

                        var oldEntity = await _context.Set<T>().FindAsync(pkValue);

                        var InsertTime = _context.Entry(oldEntity).Property("InsertTime").CurrentValue;
                       
                        if (oldEntity != null)
                        {
                            _context.Set<T>().Remove(oldEntity);

                            await _context.SaveChangesAsync();
                        }

                        entry.Property("Id").CurrentValue = entry.Property("NewId").CurrentValue;
                        entry.Property("UpdateTime").CurrentValue = DateTime.Now;
                        entry.Property("InsertTime").CurrentValue = InsertTime;
                        await _context.Set<T>().AddAsync(Object);
                    }
                    
                }
                else
                {
                    entry.CurrentValues.SetValues(Object);

                    entry.State = EntityState.Modified;
                    
                    
                }
              entry.Property("InsertTime").IsModified = false;
             
              entry.Property("NewId").IsModified = false;

              entry.Property("RowVersion").CurrentValue = rowVersion;
            }
            
        }

        public async Task Delete<T>(object Object) where T : class
        {

            if (Object != null)
            {
                var isRemoved = Object.GetType().GetProperty("IsRemoved");
                var removeTime = Object.GetType().GetProperty("RemoveTime");
                if (isRemoved != null && removeTime != null)
                {
                    isRemoved.SetValue(Object, true);
                    removeTime.SetValue(Object, DateTime.Now);
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
