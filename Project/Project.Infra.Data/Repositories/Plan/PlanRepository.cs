using Project.Domain.Common.Dto;
using Project.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Repository.Plan;

namespace Project.Infra.Data.Repositories.Plan
{
    public class PlanRepository:BaseRepository.BaseRepository, IPlanRepository
    {
        private readonly DataBaseContext _context;

        public PlanRepository(DataBaseContext context) : base(context)
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
            await base.Add(Object);
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


    }
}
