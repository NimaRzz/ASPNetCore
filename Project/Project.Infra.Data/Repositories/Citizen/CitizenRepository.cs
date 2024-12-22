using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.Citizen;
using Project.Infra.Data.Contexts;

namespace Project.Infra.Data.Repositories.Citizen
{
    public class CitizenRepository: BaseRepository.BaseRepository, ICitizenRepository
    {
        private readonly DataBaseContext _context;
       
        public CitizenRepository(DataBaseContext context):base(context) { 

        _context = context;

        }

    }
}
