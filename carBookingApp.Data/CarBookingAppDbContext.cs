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
        DbSet<Car> cars { get; set; }
    }
}
