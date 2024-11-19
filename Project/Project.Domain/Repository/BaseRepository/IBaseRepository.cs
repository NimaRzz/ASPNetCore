using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repository.BaseRepository
{
    public interface IBaseRepository
    {
        Task<bool> IsExists<T>(long Id) where T : class;
    }
}
