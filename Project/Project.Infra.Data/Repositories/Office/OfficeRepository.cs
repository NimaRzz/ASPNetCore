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

        public async Task Add(Domain.Entities.Offices.Office office)
        {
            await base.Add(office);
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


    }
}
