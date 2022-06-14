using DAL.EF;
using DAL.Models;

namespace DAL.Repositories
{
    public class RoomRepository : Repository<CardVisitData>
    {
        public readonly ClinicDbContext ClinicDbContext;
        
        public RoomRepository(ClinicDbContext dbContext) : base(dbContext)
        {
            ClinicDbContext = dbContext;
        }
        
        public override Task<IEnumerable<CardVisitData>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<CardVisitData>>(ClinicDbContext.CardVisitData);
        }
        
        public override async Task<CardVisitData> UpdateAsync(CardVisitData entity)
        {
            var element = await ClinicDbContext.CardVisitData.FindAsync(entity.Id);
            
            return element;
        }
    }
}
