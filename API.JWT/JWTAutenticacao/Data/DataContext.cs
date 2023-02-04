using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTAutenticacao.Data
{
    public class DataContext : IdentityDbContext
    {

        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
    }
}
