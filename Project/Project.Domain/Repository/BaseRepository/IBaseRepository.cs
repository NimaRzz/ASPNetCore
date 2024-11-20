using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;

namespace Project.Domain.Repository.BaseRepository
{
    public interface IBaseRepository
    {
        Task<bool> IsExists<T>(long Id) where T : class;

        Task<ResultDto<T>> Get<T>(long Id) where T : class;

        Task Add(object Object);
        
        Task Update<T>(object Object) where T : class;

        Task Delete<T>(object Object) where T : class;

        Task SaveAsync();
    }
}
