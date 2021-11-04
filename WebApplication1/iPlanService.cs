using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web
{
    public interface iPlanService
    {
        Task<IEnumerable<planes>> GetPlanes();
    }
}
