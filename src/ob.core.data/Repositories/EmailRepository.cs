using Microsoft.EntityFrameworkCore;
using ob.core.data.Context;
using ob.core.domain.Entities;
using ob.core.domain.Interface.Repositories;

namespace ob.core.data.Repositories
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
        public EmailRepository(ObCoreContext context)
            : base(context)
        {

        }
    }
}
