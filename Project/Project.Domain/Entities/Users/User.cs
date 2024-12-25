using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Project.Domain.Entities.Users
{
    public class User:IdentityUser
    {
        public DateTime? InsertTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? RemoveTime { get; set; }

        public bool IsRemoved { get; set; } = false;
    }

}
