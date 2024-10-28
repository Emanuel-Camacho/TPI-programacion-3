using Domain.Entitites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAdminService
    {
        public List<Admin> GetAdmins();

        public Admin GetAdminById(int id);

        public void AddAdmin(Admin client);

        public void UpdateAdmin(int id, Admin client);
        public void DeleteAdmin(int id);
    }
}
