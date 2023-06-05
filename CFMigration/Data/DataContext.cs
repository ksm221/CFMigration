using Microsoft.EntityFrameworkCore;
namespace CFMigration.Data
{
    public class DataContext : DbContext
    {
        //konstruktor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //tulemuste nägemiseks dbset
        public DbSet<RpgCharacter> RpgCharacters => Set<RpgCharacter>();
    }
}