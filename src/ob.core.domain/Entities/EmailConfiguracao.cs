using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.domain.Entities
{
    public class EmailConfiguracao : EntidadeBase
    {
        public string SmtpServidor { get; set; }
        public int SmptPorta { get; set; }
        public string SmptEmail { get; set; }
        public string SmptSenha  { get; set; }
    }
}
