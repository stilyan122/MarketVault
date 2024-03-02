namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.DocumentTypeConstants;

    /// <summary>
    /// DocumentType Entity
    /// </summary>
    [Comment("DocumentType Entity Class")]
    public class DocumentType
    {
        /// <summary>
        /// DocumentType Identificator
        /// </summary>
        [Comment("DocumentType Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// DocumentType Name
        /// </summary>
        [Comment("DocumentType Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Collection with Operation Entity
        /// </summary>
        public ICollection<Operation> Operations { get; set; }
            = new List<Operation>();
    }
}
