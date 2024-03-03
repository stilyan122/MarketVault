namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ProductConstants;

    /// <summary>
    /// Product Entity
    /// </summary>
    [Comment("Product Entity Class")]
    public class Product
    {
        /// <summary>
        /// Product Identificator
        /// </summary>
        [Comment("Product Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [Comment("Product Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product Cash Register Name
        /// </summary>
        [Comment("Product Cash Register Name")]
        [MaxLength(CashRegisterNameMaxLength)]
        [Required]
        public string CashRegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Product Article Number
        /// </summary>
        [Comment("Product Article Number")]
        [Range(NumberMinValue, NumberMaxValue)]
        [Required]
        public int ArticleNumber { get; set; }

        /// <summary>
        /// Product Nomenclature Number
        /// </summary>
        [Comment("Product Nomenclature Number")]
        [Range(NumberMinValue, NumberMaxValue)]
        [Required]
        public int NomenclatureNumber { get; set; }

        /// <summary>
        /// Product Code for scales
        /// </summary>
        [Comment("Product Code for scales")]
        [Range(NumberMinValue, NumberMaxValue)]
        [Required]
        public int CodeForScales { get; set; }

        /// <summary>
        /// Product Purchase Price
        /// </summary>
        [Comment("Product Purchase Price")]
        [Required]
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Procuct Sale Price
        /// </summary>
        [Comment("Product Sale Price")]
        [Required]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        [Comment("Product Description")]
        [MaxLength(DescriptionMaxLength)]
        [Required]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product Quantity
        /// </summary>
        [Comment("Product Quantity")]
        public decimal Quantity { get; set; } = 0;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// ItemGroupId - foreign key
        /// </summary>
        [Comment("ItemGroupId - FK")]
        [ForeignKey(nameof(ItemGroup))]
        [Required]
        public int ItemGroupId { get; set; }

        /// <summary>
        /// ItemGroup Entity
        /// </summary>
        public ItemGroup ItemGroup { get; set; } = null!;

        /// <summary>
        /// Date when the product was added
        /// </summary>
        [Comment("Date when the product was added")]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        /// <summary>
        /// Date when the product was last modified
        /// </summary>
        [Comment("Date when the product was last modified")]
        public DateTime DateModified { get; set; } = DateTime.Now;

        /// <summary>
        /// Collection with Barcode Entities
        /// </summary>
        public IEnumerable<Barcode> Barcodes { get; set; }
            = new List<Barcode>();

        /// <summary>
        /// Collection with entities from the mapping table - ProductsMeasures
        /// </summary>
        public IEnumerable<ProductMeasure> ProductsMeasures { get; set; }
            = new List<ProductMeasure>();

        /// <summary>
        /// Collection with entities from the mapping table - ProductsOperations
        /// </summary>
        public IEnumerable<ProductOperation> ProductsOperations { get; set; }
            = new List<ProductOperation>();
    }
}
