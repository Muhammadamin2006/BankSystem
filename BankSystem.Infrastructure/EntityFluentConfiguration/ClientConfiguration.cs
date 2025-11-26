using BankSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankSystem.Infrastructure.EntityFluentConfiguration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients");
        builder.HasKey(x => x.ClientId);
        
        builder.HasIndex(x => x.ClientId)
            .IsUnique()
            .HasDatabaseName("IDX_ClientId");
        builder.Property(x => x.ClientId)
            .ValueGeneratedOnAdd() 
            .IsRequired()
            .HasColumnType("uniqueidentifier")
            .HasColumnName("ClientId")
            .HasDefaultValueSql("NEWID()"); 
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(100)");

        builder.HasIndex(x => x.PassportNumber)
            .IsUnique()
            .HasDatabaseName("IDX_Client_PassportNumber");
        builder.Property(x => x.PassportNumber)
            .IsRequired()
            .HasColumnName("PassportNumber")
            .HasColumnType("nchar(7)");

    }
}