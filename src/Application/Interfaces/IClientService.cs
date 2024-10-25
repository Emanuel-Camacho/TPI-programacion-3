using Domain.Entitites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientService
    {
        public List<Client> GetClients();

        public Client GetClientById(int id);

        public void AddClient(Client client);

        public void UpdateClient(int id, Client client);
        public void DeleteClient(int id);
    }
}
