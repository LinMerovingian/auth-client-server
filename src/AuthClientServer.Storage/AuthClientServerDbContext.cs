namespace AuthClientServer.Storage
{
    using Microsoft.EntityFrameworkCore;

    public class AuthClientServerDbContext : DbContext
    {
        public AuthClientServerDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new ResourceMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Resource> Resource { get; set; }
    }
}
