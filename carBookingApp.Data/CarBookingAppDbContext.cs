using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carBookingApp.Data
{
    public class CarBookingAppDbContext : DbContext
    {

        public CarBookingAppDbContext(DbContextOptions<CarBookingAppDbContext> options) : base(options)
        {

        }

        DbSet<Car> cars { get; set; }
    }
}
