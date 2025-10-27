using System;
using System.Collections.Generic;
using Eclipse360.Models;
using Microsoft.EntityFrameworkCore;

namespace Eclipse360.Data;

public partial class EclipseDictionaryContext : DbContext
{
    public EclipseDictionaryContext(DbContextOptions<EclipseDictionaryContext> options)
        : base(options)
    { }
          public  DbSet<Catergory_Deleted> Catergories { get; set; }

    public  DbSet<CatergoryFor_Deleted> CatergoryFors { get; set; }

    public  DbSet<CountryList> CountryLists { get; set; }

    public  DbSet<Lead_Deleted> Leads { get; set; }

    public  DbSet<LeadCatergory_Deleted> LeadCatergories { get; set; }

    public  DbSet<Status_Deleted> Statuses { get; set; }

    public  DbSet<StatusFor_Deleted> StatusFors { get; set; }


  

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLDDLFV;Initial Catalog=EclipseDictionary;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Catergory>(entity =>
//        {
//            entity.ToTable("Catergory");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(50);

//            entity.HasOne(d => d.CatForNavigation).WithMany(p => p.Catergories)
//                .HasForeignKey(d => d.CatFor)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Catergory_CatergoryFor");
//        });

//        modelBuilder.Entity<CatergoryFor>(entity =>
//        {
//            entity.ToTable("CatergoryFor");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(50);
//        });

//        modelBuilder.Entity<CountryList>(entity =>
//        {
//            entity
//                .HasNoKey()
//                .ToTable("CountryList");

//            entity.Property(e => e.Continents)
//                .HasMaxLength(15)
//                .IsFixedLength();
//            entity.Property(e => e.Currency)
//                .HasMaxLength(10)
//                .IsFixedLength();
//            entity.Property(e => e.CurrencySymbol)
//                .HasMaxLength(10)
//                .IsFixedLength();
//            entity.Property(e => e.FlagSymb)
//                .HasMaxLength(10)
//                .IsFixedLength();
//            entity.Property(e => e.NameAr).HasMaxLength(50);
//            entity.Property(e => e.NameEn).HasMaxLength(50);
//            entity.Property(e => e.TelCode)
//                .HasMaxLength(4)
//                .IsFixedLength();
//        });

//        modelBuilder.Entity<Lead>(entity =>
//        {
//            entity.ToTable("Lead");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(50);

//            entity.HasOne(d => d.CatNavigation).WithMany(p => p.Leads)
//                .HasForeignKey(d => d.Cat)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Lead_LeadCatergory");
//        });

//        modelBuilder.Entity<LeadCatergory>(entity =>
//        {
//            entity.ToTable("LeadCatergory");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(50);
//        });

//        modelBuilder.Entity<Status>(entity =>
//        {
//            entity.ToTable("Status");

//            entity.Property(e => e.Description).HasColumnType("text");
//            entity.Property(e => e.Name).HasMaxLength(50);

//            entity.HasOne(d => d.StatusForNavigation).WithMany(p => p.Statuses)
//                .HasForeignKey(d => d.StatusFor)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Status_StatusFor");
//        });

//        modelBuilder.Entity<StatusFor>(entity =>
//        {
//            entity.ToTable("StatusFor");

//            entity.Property(e => e.Name).HasMaxLength(50);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
