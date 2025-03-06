using LibraryAPP.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPP.Data
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options):base(options) 
        {

        }
        public DbSet<BookModel> AllBooks {  get; set; }
    }
}
