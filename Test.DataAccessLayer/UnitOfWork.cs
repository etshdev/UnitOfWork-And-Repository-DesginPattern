using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test.DataAccessLayer
{
   public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(TestRepoDB testRepoDB) => this.TestRepoDB = testRepoDB;
           
        public TestRepoDB TestRepoDB { get; }
            

        public IDbContextTransaction dbContextTransaction { get ; set ; }

        public void commit()
        {
            TestRepoDB.Database.CurrentTransaction.Commit();
        }

        public void Dispose()
        {
            TestRepoDB.Dispose();
        }

        public bool SaveChanges()
        {
            try
            {
               return  TestRepoDB.SaveChanges() > 0 ? true : false;
            }
            catch 
            {

                return false;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return (await TestRepoDB.SaveChangesAsync()) > 0 ? true : false;
            }
            catch 
            {
                return false;
            }
        }
    }
}
