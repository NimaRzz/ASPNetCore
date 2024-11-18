using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Application.Common.Roles;
using Project.Domain.Entities.Citizens;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Plans;
using Project.Domain.Entities.Turns;
using Project.Domain.Entities.Users;

namespace Project.Infra.Data.Contexts
{
    public class DataBaseContext:DbContext
    {
        #region ctor

        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        #endregion

        #region Properties

        public DbSet<Office> Offices { get; set; }
      
        public DbSet<OfficePlan> OfficePlans { get; set; }
      
        public DbSet<Shift> Shifts { get; set; }
       
        public DbSet<WorkCalendar> WorkCalendars { get; set; }

        public DbSet<Citizen> Citizens { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Plan> Plans { get; set; }
       
        public DbSet<User> Users { get; set; }
      
        public DbSet<Role> Roles { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<OfficePlan>()
                .HasOne(op => op.Office)
                .WithMany(o => o.OfficePlans)
                .HasForeignKey(op => op.OfficeId)
                .OnDelete(DeleteBehavior.NoAction); 

           
            modelBuilder.Entity<WorkCalendar>()
                .HasMany(w => w.Shifts)
                .WithOne(s => s.WorkCalendar)
                .HasForeignKey(s => s.WorkCalendarId)
                .OnDelete(DeleteBehavior.NoAction);

           
            modelBuilder.Entity<OfficePlan>()
                .HasOne(op => op.Plan)
                .WithMany(p => p.OfficePlans)
                .HasForeignKey(op => op.PlanId)
                .OnDelete(DeleteBehavior.NoAction);

            // پیکربندی روابط یک به چند برای Appointment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Citizen)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.CitizenId)
                .OnDelete(DeleteBehavior.Cascade);  // Cascade Delete برای Citizen

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Plan)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.PlanId)
                .OnDelete(DeleteBehavior.Cascade);  // Cascade Delete برای Plan

            // پیکربندی برای ارتباط میان User و UserInRole
            modelBuilder.Entity<UserInRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserInRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);  // وقتی یک کاربر حذف شود، نقش‌های مربوط به آن نیز حذف شوند

            // پیکربندی برای ارتباط میان Role و UserInRole
            modelBuilder.Entity<UserInRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserInRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);  // وقتی یک نقش حذف شود، کاربران مربوط به آن نقش نیز حذف شوند

            modelBuilder.Entity<Office>()
                .Property(c => c.Id)
                .ValueGeneratedNever();


            //SeedData 
            SeedData(modelBuilder);

            //--برایه عدم نمایش اطلاعات حذف شده
            ApplyQueryFilter(modelBuilder);

        }

        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Citizen>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Office>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Plan>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Appointment>().HasQueryFilter(p => !p.IsRemoved);

        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //Roles
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = nameof(UserRoles.Citizen) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 3, Name = nameof(UserRoles.Operator) });

        }

        #endregion
    }
}
