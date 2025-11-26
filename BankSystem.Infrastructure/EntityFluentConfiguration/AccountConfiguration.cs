using BankSystem.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankSystem.Infrastructure.EntityFluentConfiguration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        // builder.ToTable("Accounts");
        // builder.HasKey(x => x.Id);
        //
        // builder.HasIndex(x => x.ClientId)
        //     .HasDatabaseName("IDX_ClientId")
        //     .IsUnique();
        // builder.Property(x => x.Id)
        //     .HasColumnName("Id")
        //     .ValueGeneratedOnAdd()
        //     .IsRequired()
        //     .HasColumnType("uniqueidentifier")
        //     .HasDefaultValueSql("newid()");
        //
        // // builder.HasOne(x => x.Client)
        // //     .WithMany(x => x.Accounts)
        // //     .HasForeignKey(x => x.ClientId)
        // //     .OnDelete(DeleteBehavior.Restrict);
        //
        // builder.Property(x => x.CreatedDate)
        //     .HasColumnName("CreatedDate")
        //     .ValueGeneratedOnAdd()
        //     .HasColumnType("datetime")
        //     .HasDefaultValueSql("getdate()");
        //
        // builder.Property(x => x.Type)
        //     .HasColumnName("Type")
        //     .HasColumnType("nvarchar(50)")
        //     .IsRequired();
        //
        // builder.Property(x => x.TypeId)
        //     .HasColumnName("TypeId")
        //     .ValueGeneratedOnAdd()
        //     .HasColumnType("uniqueidentifier")
        //     .IsRequired()
        //     .HasDefaultValueSql("newid()");
        //
        // builder.Property(x => x.Balance)
        //     .HasColumnName("Balance")
        //     .HasColumnType("decimal(18,2)")
        //     .HasPrecision(18, 2)
        //     .HasDefaultValueSql("(0,0)");
        //
        // builder.Property(x => x.ClosedDate)
        //     .HasColumnName("ClosedDate")
        //     .HasColumnType("datetime");
        //
        // builder.Property(x => x.IsActive)
        //     .HasDefaultValue(true);
        //
        // builder.Property(x => x.UpdatedDate)
        //     .HasColumnName("UpdatedDate")
        //     .ValueGeneratedOnAdd()
        //     .HasColumnType("datetime")
        //     .HasDefaultValueSql("getdate()");
    }
}