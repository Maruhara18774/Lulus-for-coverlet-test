using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Infrastructure
{
    public class DbFactory : Disposable,IDFactory
    {
        private LulusDbContext dbContext;

        public LulusDbContext Init()
        {
            return dbContext ?? (dbContext = new LulusDbContext());

        }
        protected override void DisposeCore()
        {
            if(dbContext!=null)
            {
                dbContext.Dispose();

            }
        }
    }
}
