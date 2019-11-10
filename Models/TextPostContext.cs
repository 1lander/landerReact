using Microsoft.EntityFrameworkCore;

namespace landerReact.Models
{
    public class TextPostContext : DbContext
    {
        public TextPostContext(DbContextOptions<TextPostContext> options)
                                    : base(options)
        {

        }
        public DbSet<TextPost> TextPost { get; set; }
    }
}
