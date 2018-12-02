using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace CurrencyExchanger.packages.model
{
    public partial class CurrencyexchangerContext : DbContext
    {
        public CurrencyexchangerContext()
        {
        }

        public CurrencyexchangerContext(DbContextOptions<CurrencyexchangerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:currencyexchanger.database.windows.net,1433;Initial Catalog=currencyexchanger;Persist Security Info=False;User ID=alexei0tereshchenko;Password=Lyosha_19;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("CURRENCY");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("NAME_CURRENCY")
                    .IsUnique();

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CURRENCY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasColumnName("CURRENCY_NAME")
                    .HasMaxLength(3);

                entity.Property(e => e.Purchase).HasColumnName("PURCHASE");

                entity.Property(e => e.Sell).HasColumnName("SELL");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("PERSON");

                entity.HasIndex(e => e.PersonId)
                    .HasName("PASSPORT_PERSON")
                    .IsUnique();

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(15);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(15);

                entity.Property(e => e.PassportId)
                    .IsRequired()
                    .HasColumnName("PASSPORT_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.PassportSeries)
                    .IsRequired()
                    .HasColumnName("PASSPORT_SERIES")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("REPORT");

                entity.Property(e => e.ReportId)
                    .HasColumnName("REPORT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IncomAmount).HasColumnName("INCOM_AMOUNT");

                entity.Property(e => e.OutcomeAmount).HasColumnName("OUTCOME_AMOUNT");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORT_CURRENCY");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORT_PERSON");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORT_USER");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.HasIndex(e => e.UserId)
                    .HasName("LOGIN_USER")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(10);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(10);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(10);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(10);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(10);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(10);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(10);
            });
        }
    }
}
