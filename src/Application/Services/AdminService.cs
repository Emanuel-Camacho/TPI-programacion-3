using Application.Interfaces;
using Domain.Entitites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _clientRepository;

        public AdminService(IAdminRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Admin> GetAdmins()
        {
            return _clientRepository.GetAll();
        }

        public Admin GetAdminById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void AddAdmin(Admin client)
        {
            _clientRepository.Add(client);
        }

        public void UpdateAdmin(int id, Admin client)
        {
            _clientRepository.Update(id, client);
        }
        public void DeleteAdmin(int id)
        {
            var client = _clientRepository.GetById(id);
            _clientRepository.Delete(client);
        }
    }
}
