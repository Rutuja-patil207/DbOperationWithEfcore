using Microsoft.EntityFrameworkCore;

namespace DbcontextWebApi.Data
{
    public class AppDbContext :DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
    }
}
