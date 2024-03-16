namespace MarketVault.Data
{
    using MarketVault.Infrastructure.Data.Configurations;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// App DB Context
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// Default DB Context Constructor
        /// </summary>
        /// <param name="options">DB Context options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet with Address Entity
        /// </summary>
        public DbSet<Address> Addresses { get; set; } = null!;

        /// <summary>
        /// DbSet with Bank Entity
        /// </summary>
        public DbSet<Bank> Banks { get; set; } = null!;

        /// <summary>
        /// DbSet with Barcode Entity
        /// </summary>
        public DbSet<Barcode> Barcodes { get; set; } = null!;

        /// <summary>
        /// DbSet with CounterParty Entity
        /// </summary>
        public DbSet<CounterParty> CounterParties { get; set; } = null!;

        /// <summary>
        /// DbSet with DocumentType Entity
        /// </summary>
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;

        /// <summary>
        /// DbSet with Firm Entity
        /// </summary>
        public DbSet<Firm> Firms { get; set; } = null!;

        /// <summary>
        /// DbSet with ItemGroup Entity
        /// </summary>
        public DbSet<ItemGroup> ItemGroups { get; set; } = null!;

        /// <summary>
        /// DbSet with Measure Entity
        /// </summary>
        public DbSet<Measure> Measures { get; set; } = null!;

        /// <summary>
        /// DbSet with Operation Entity
        /// </summary>
        public DbSet<Operation> Operations { get; set; } = null!;

        /// <summary>
        /// DbSet with Product Entity
        /// </summary>
        public DbSet<Product> Products { get; set; } = null!;

        /// <summary>
        /// DbSet with ProductMeasure Entity
        /// </summary>
        public DbSet<ProductMeasure> ProductsMeasures { get; set; } = null!;

        /// <summary>
        /// DbSet with ProductOperation Entity
        /// </summary>
        public DbSet<ProductOperation> ProductsOperations { get; set; } = null!;

        /// <summary>
        /// Method for configuring DB / Models
        /// </summary>
        /// <param name="builder">Default Model Builder</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductMeasure>()
                .HasKey(pm => new
                {
                    pm.MeasureId,
                    pm.ProductId
                });

            builder.Entity<ProductOperation>()
                .HasKey(po => new
                {
                    po.OperationId,
                    po.ProductId
                });

            builder.Entity<CounterParty>()
                .HasOne(cp => cp.Firm)
                .WithMany(f => f.CounterParties)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Product>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            ApplyConfigurations(builder);

            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Private method for applying configurations
        /// </summary>
        /// <param name="builder">Default Model Builder</param>
        private static void ApplyConfigurations(ModelBuilder builder)
        {
            builder
            .ApplyConfiguration(new AddressConfiguration())
            .ApplyConfiguration(new BankConfiguration())
            .ApplyConfiguration(new FirmConfiguration())
            .ApplyConfiguration(new DocumentTypeConfiguration())
            .ApplyConfiguration(new CounterPartyConfiguration())
            .ApplyConfiguration(new ItemGroupConfiguration())
            .ApplyConfiguration(new MeasureConfiguration())
            .ApplyConfiguration(new OperationConfiguration())
            .ApplyConfiguration(new ProductConfiguration())
            .ApplyConfiguration(new BarcodeConfiguration())
            .ApplyConfiguration(new ProductMeasureConfiguration())
            .ApplyConfiguration(new ProductOperationConfiguration());
        }
    }
}
