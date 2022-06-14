using DAL.Models;

namespace BLL.Interfaces
{
    public interface IBookingService : IService<Doctor>
    {
        public Task<IEnumerable<CardVisitData>> GetFreeRoomsInPeriod(DateTime dateTime1, DateTime dateTime2);
    }
}
