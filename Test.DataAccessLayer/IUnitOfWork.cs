using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test.DataAccessLayer
{
   public interface IUnitOfWork:IDisposable
    {

        TestRepoDB TestRepoDB { get; }

        IDbContextTransaction dbContextTransaction { get; set; }

        void commit();

        bool SaveChanges();

        Task<bool> SaveChangesAsync();

    }
}
