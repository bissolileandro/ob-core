using ob.core.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class ParametrosDeSistema : EntidadeBase
    {
        public string UrlApi { get; set; }
        public EnumAmbienteDeSistema Ambiente { get; set; }
        public int SistemaId { get; set; }
        public virtual Sistema Sistema { get; set; }
    }
}
