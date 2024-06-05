using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.application.Models
{
    public class SistemaModel : BaseModel
    {
        public string Nome { get; set; }
        public Guid ChaveDeAcesso { get; set; }
        public bool Ativo { get; set; }
    }
}
