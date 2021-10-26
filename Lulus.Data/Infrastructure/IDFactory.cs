using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Infrastructure
{
    public interface IDFactory : IDisposable
    {
        LulusDbContext Init();
    }
}
