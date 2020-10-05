using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DataAccessLayer
{
   public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllAsNoTracking();
        Task<IQueryable<T>> GetAllAsync();
        T GetById(object Id);
        IQueryable<T> Find(Func<T, bool> predicate);
        bool Insert(T entity);
        bool InsertRange(IEnumerable<T> entities);
        void InsertWithoutSaveChange(T entity);
        void InsertRangeWithoutSaveChange(IEnumerable<T> entities);
        Task<bool> InsertAsync();
        bool Update(T entity);
        void UpdateWithoutSaveChange();
        Task<bool> UpdateAsync(T entity);
        bool Delete(T entity);
        Task<bool> DeleteAsync(T entity);
        bool DeleteRange(IEnumerable<T> entities);
        void DeleteWithoutSaveChange(T entity);
        void DeleteRangeWithoutSaveChange(IEnumerable<T> entities);
        bool SaveChange();
        Task<bool> SaveChangeAsync();




    }
}
