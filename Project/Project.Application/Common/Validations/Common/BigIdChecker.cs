using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Common.Validations.Common
{
    public class BigIdChecker
    {
        public static async Task<bool> IsBig(long Id)
        {
            if (Id > 100)
            {
                return true;
            }
            return false;
        } 
    }
}
