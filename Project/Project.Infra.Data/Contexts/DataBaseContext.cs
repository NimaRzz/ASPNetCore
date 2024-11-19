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
using Project.Domain.Entities.Province;
using ProvinceNames = Project.Application.Common.Provinces.Province;

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
     
        public DbSet<Province> Provinces { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentApi
            ConfigureFluentApi(modelBuilder);

            //SeedData 
            SeedData(modelBuilder);

            //--برایه عدم نمایش اطلاعات حذف شده
            ApplyQueryFilter(modelBuilder);

        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                if (entry.Entity is Office office)
                {
                    // زمانی که رکورد آپدیت می‌شود، تاریخ و زمان آپدیت را ثبت می‌کنیم
                    office.UpdateTime = DateTime.Now;  // یا DateTime.Now به دلخواه
                }
            }

            return base.SaveChanges();
        }

        private void ConfigureFluentApi(ModelBuilder modelBuilder)
        {
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

            // پیکربندی رابطه یک به چند بین استان و دفتر
            modelBuilder.Entity<Office>()
                .HasOne(o => o.Province) // هر دفتر متعلق به یک استان است
                .WithMany(p => p.Offices) // هر استان می‌تواند چندین دفتر داشته باشد
                .HasForeignKey(o => o.ProvinceId) // کلید خارجی دفتر به استان
                .OnDelete(DeleteBehavior.Cascade); // حذف دفاتر هنگام حذف استان (در صورت نیاز)

            modelBuilder.Entity<Office>()
                .Property(c => c.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Office>()
                .Property(c => c.InsertTime)
                .HasDefaultValueSql("GETDATE()");

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

            //Provinces
            modelBuilder.Entity<Province>().HasData(new Province { Id = 1, Name = nameof(ProvinceNames.AzarbaijanSharghi) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 2, Name = nameof(ProvinceNames.AzarbaijanGharbi) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 3, Name = nameof(ProvinceNames.Ardabil) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 4, Name = nameof(ProvinceNames.Isfahan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 5, Name = nameof(ProvinceNames.Alborz) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 6, Name = nameof(ProvinceNames.Ilam) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 7, Name = nameof(ProvinceNames.Bushehr) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 8, Name = nameof(ProvinceNames.Tehran) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 9, Name = nameof(ProvinceNames.ChaharmahaloBakhtiari) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 10, Name = nameof(ProvinceNames.KhorasanJonubi) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 11, Name = nameof(ProvinceNames.KhorasanRazavi) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 12, Name = nameof(ProvinceNames.KhorasanShomali) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 13, Name = nameof(ProvinceNames.Khuzestan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 14, Name = nameof(ProvinceNames.Zanjan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 15, Name = nameof(ProvinceNames.Semnan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 16, Name = nameof(ProvinceNames.SistanoBaluchestan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 17, Name = nameof(ProvinceNames.Fars) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 18, Name = nameof(ProvinceNames.Qazvin) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 19, Name = nameof(ProvinceNames.Qom) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 20, Name = nameof(ProvinceNames.Kurdistan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 21, Name = nameof(ProvinceNames.Kerman) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 22, Name = nameof(ProvinceNames.Kermanshah) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 23, Name = nameof(ProvinceNames.KohgiluyehoBoyerahmad) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 24, Name = nameof(ProvinceNames.Golestan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 25, Name = nameof(ProvinceNames.Gilan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 26, Name = nameof(ProvinceNames.Lorestan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 27, Name = nameof(ProvinceNames.Mazandaran) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 28, Name = nameof(ProvinceNames.Markazi) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 29, Name = nameof(ProvinceNames.Hormozgan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 30, Name = nameof(ProvinceNames.Hamadan) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 31, Name = nameof(ProvinceNames.Yazd) });
        }

        #endregion
    }
}
