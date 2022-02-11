using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Actor Update(int id,Actor actor);
        void Delete(int id);
        Task AddAsync(Actor actor);
        Task<Actor> GetByIdAsync(int id);
    }
}
