using Domain.Entitites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private static List<T> _entities = new List<T>();

        public List<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities[id];
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(int id, T entity)
        {
            _entities[id] = entity;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
