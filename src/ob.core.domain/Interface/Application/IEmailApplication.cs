using ob.core.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Interface.Application
{
    public interface IEmailApplication : IApplicationBase<Email>
    {
        Task EnviarEmail(string token, Usuario usuario);
    }
}
