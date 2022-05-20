using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_Login_and_Registration_ASPCore_.Models
{
    public class ASPCoreLearnResLogDbContext :IdentityDbContext
    {
        public ASPCoreLearnResLogDbContext(DbContextOptions<ASPCoreLearnResLogDbContext>options):base(options)
        {

        }
    }
}
