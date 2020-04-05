namespace AuthClientServer.Storage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class Client
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }

    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id).IsClustered();

            builder.Property(x => x.ClientId)
                .HasColumnType("NVARCHAR(256)")
                .HasMaxLength(256)
                .IsRequired();

            builder.HasOne(x => x.Resource).WithOne()
                .HasForeignKey<Client>(x => x.ResourceId);

            builder.Property(x => x.ClientName)
                .HasColumnType("VARCHAR(256)")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("VARCHAR(512)")
                .HasMaxLength(256);

            builder.Property(x => x.Enable)
                .HasColumnType("BIT")
                .IsRequired();
        }
    }
}
