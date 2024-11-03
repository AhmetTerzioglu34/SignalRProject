using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DAL.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {

        private readonly SignalRContext _context;
        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }


        public void Add(T entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            Save();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
