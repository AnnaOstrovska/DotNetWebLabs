using DAL.EF;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace DAL.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ClinicDbContext _clinicDbContext;

        public IRepository<CardVisitData> Rooms { get; }

        public IBookingRepository Bookings { get; }

        public UnitOfWork(ClinicDbContext clinicDbContext)
        {
            _clinicDbContext = clinicDbContext;

            Rooms = new RoomRepository(_clinicDbContext);
            Bookings = new BookingRepository(_clinicDbContext);
        }

        public async Task CompleteAsync()
        {
            await _clinicDbContext.SaveChangesAsync();
        }

        private void Dispose()
        {
            _clinicDbContext.Dispose();
        }

#pragma warning disable CA1816
        void IDisposable.Dispose()
#pragma warning restore CA1816
        {
            Dispose();
        }

        void IUnitOfWork.Dispose()
        {
            Dispose();
        }
    }
}
