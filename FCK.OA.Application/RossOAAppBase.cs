using FCK.OA.EntityFramework.Model;
using FCK.OA.Repositories;
using System;

namespace FCK.OA.Application
{
    public class RossOAppBase: IDisposable
    {
        protected EntityFramework.RossOADbContext dbContext;
        public RossOAppBase()
        {
            dbContext = new EntityFramework.RossOADbContext();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
