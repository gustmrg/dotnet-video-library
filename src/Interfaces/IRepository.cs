using System.Collections.Generic;

namespace VideoLibrary.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T FindById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
        
    }
}
