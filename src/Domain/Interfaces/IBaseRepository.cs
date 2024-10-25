using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        private static List<T> _entities = new List<T>();

        public List<T> GetAll();

        public T GetById(int id);

        public void Add(T entity);

        public void Update(int id, T entity);

        public void Delete(T entity);
    }
}
