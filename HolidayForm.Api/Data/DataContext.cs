using HolidayPlanner.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace HolidayPlanner.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }


        public DbSet<HolidayForm> HolidayForms { get; set; }
    }
}
