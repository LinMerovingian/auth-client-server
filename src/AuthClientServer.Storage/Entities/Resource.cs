namespace AuthClientServer.Storage
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class Resource
    {
        public int Id { get; set; }
        public bool Enable { get; set; }
    }

    public class ResourceMap : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("Resource");
            builder.HasKey(x => x.Id).IsClustered();

            builder.Property(x => x.Enable)
                .HasColumnType("BIT")
                .IsRequired();
        }
    }
}
