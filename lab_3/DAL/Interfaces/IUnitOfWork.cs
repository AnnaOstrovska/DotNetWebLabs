using DAL.Models;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<CardVisitData> Rooms { get; }
        IBookingRepository Bookings { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
