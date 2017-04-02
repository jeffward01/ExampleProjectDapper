using Dapper.Models;
using Dapper.Models.LU_Tables;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dapper.Data.Infrastructure
{
    public class SampleProjectContext : IdentityDbContext<IdentityUser>
    {
        public SampleProjectContext() : base("SampleProjectContext")
        {
            try
            {
                //   Database.SetInitializer<SampleProjectContext>(null);
                Configuration.ProxyCreationEnabled = false;
                Configuration.AutoDetectChangesEnabled = false;
               // Database.SetInitializer<IdentityDbContext>(null);
            }
            catch (Exception e)
            {
                //Logger.Debug("_____CRTIICAL ERROR_____________");
                //Logger.Debug("An Error occurred trying to connect to the database " + e.ToString());
            }
        }

        public DbSet<License> Licenses { get; set; }

        public DbSet<LicenseProduct> LicenseProducts { get; set; }

        public DbSet<ProductHeader> ProductHeaders { get; set; }
        public DbSet<ProductConfiguration> ProductConfigurations { get; set; }
        public DbSet<Recording> Recordings { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<TrackComposer> TrackComposers { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<WriterOriginalPublisher> WriterOriginalPublishers { get; set; }

        public DbSet<Artist> Artists { get; set; }

        //Lookup tables
        public DbSet<LU_LicenseStatus> LicenseStatuses { get; set; }

        public DbSet<ConfigurationType> ConfigurationTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         //   modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<License>().ToTable("Licenses");
            modelBuilder.Entity<License>().HasKey(_ => _.LicenseId);
            modelBuilder.Entity<License>()
                .HasMany(_ => _.LicenseProducts)
                .WithOptional()
                .HasForeignKey(_ => _.LicenseId);
            modelBuilder.Entity<License>()
                .HasRequired(_ => _.LicesneStatus)
                .WithMany()
                .HasForeignKey(_ => _.LicenseStatusId);

            modelBuilder.Entity<ProductHeader>().ToTable("ProductHeaders");
            modelBuilder.Entity<ProductHeader>().HasKey(_ => _.ProductHeaderId);
            modelBuilder.Entity<ProductHeader>()
                .HasMany(_ => _.ProductConfigurations)
                .WithOptional()
                .HasForeignKey(_ => _.ProductHeaderId);

            modelBuilder.Entity<ProductConfiguration>().ToTable("ProductConfigurations");
            modelBuilder.Entity<ProductConfiguration>().HasKey(_ => _.ProductConfigurationId);
            modelBuilder.Entity<ProductConfiguration>()
                .HasRequired(_ => _.ConfigurationType)
                .WithMany()
                .HasForeignKey(_ => _.ConfigurationId);

            modelBuilder.Entity<LicenseProduct>().ToTable("LicenseProducts");
            modelBuilder.Entity<LicenseProduct>().HasKey(_ => _.LicenseProductId);
            modelBuilder.Entity<LicenseProduct>()
                .HasMany(_ => _.Recordings)
                .WithOptional()
                .HasForeignKey(_ => _.LicenseProductId).WillCascadeOnDelete(false);
            modelBuilder.Entity<LicenseProduct>()
                .HasRequired(_ => _.ProductHeader)
             .WithMany().HasForeignKey
                
                (_ => _.ProductHeaderId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Recording>().ToTable("Recordings");
            modelBuilder.Entity<Recording>().HasKey(_ => _.RecordingId);
            modelBuilder.Entity<Recording>()
                .HasMany(_ => _.Writers)
                .WithOptional()
                .HasForeignKey(_ => _.RecordingId);
            modelBuilder.Entity<Recording>()
                .HasRequired(_ => _.Track)
                .WithMany()
                .HasForeignKey(_ => _.TrackId);

            modelBuilder.Entity<Track>().ToTable("Tracks");
            modelBuilder.Entity<Track>().HasKey(_ => _.TrackId);
            modelBuilder.Entity<Track>()
                .HasMany(_ => _.Composers)
                .WithOptional()
                .HasForeignKey(_ => _.TrackComposerId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Track>()
                .HasRequired(_ => _.Artist)
                .WithMany()
                .HasForeignKey(_ => _.ArtistId);

            modelBuilder.Entity<TrackComposer>().ToTable("TrackComposers");
            modelBuilder.Entity<TrackComposer>().HasKey(_ => _.TrackId);

            modelBuilder.Entity<Writer>().ToTable("Writers");
            modelBuilder.Entity<Writer>().HasKey(_ => _.WriterId);
            modelBuilder.Entity<Writer>()
                .HasMany(_ => _.OriginalPublishers)
                .WithOptional()
                .HasForeignKey(_ => _.WriterId);


            modelBuilder.Entity<Artist>().ToTable("Artists");
            modelBuilder.Entity<Artist>().HasKey(_ => _.ArtistId);

            modelBuilder.Entity<LU_LicenseStatus>().ToTable("LU_LicenseStatuses");
            modelBuilder.Entity<LU_LicenseStatus>().HasKey(_ => _.LicenseStatusId);

            modelBuilder.Entity<ConfigurationType>().ToTable("ConfigurationTypes");
            modelBuilder.Entity<ConfigurationType>().HasKey(_ => _.ConfigurationTypeId);

            base.OnModelCreating(modelBuilder);
        }
    }
}