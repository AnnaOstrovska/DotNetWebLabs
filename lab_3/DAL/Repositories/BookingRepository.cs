using DAL.EF;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BookingRepository : Repository<Doctor>, IBookingRepository
    {
        public readonly ClinicDbContext ClinicDbContext;
        public BookingRepository(ClinicDbContext dbContext) : base(dbContext)
        {
            ClinicDbContext = dbContext;
        }

    }
}
