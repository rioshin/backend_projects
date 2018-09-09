using System;
using System.Threading.Tasks;
using Teht_2;

namespace Teht_2
{
    public class PlayersProcessor
    {
        public Task<Player> Get(Guid id);
        public Task<Player[]> GetAll();
        public Task<Player> Create(NewPlayer player);
        public Task<Player> Modify(Guid id, ModifiedPlayer player);
        public Task<Player> Delete(Guid id);
    }
}
