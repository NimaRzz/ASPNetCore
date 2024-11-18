using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.BaseEntity;

namespace Project.Infra.Data.Contexts
{
    public class DataBaseContext:DbContext
    {
        #region ctor

        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        #endregion

        #region DbSets



        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BaseEntity>().HasKey(p => p.Id);
        }

        #endregion
    }
}
