using Domain.Entitites;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    { 
        private readonly ApplicationContext _context;

        public ClientRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Client> Get()
        {
            return _context.Clients.ToList();
        }

        public int Add(Client cli)
        {
            _context.Clients.Add(cli);
            _context.SaveChanges();
            return cli.Id;
        }
    }
}
