using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketplaceWeb.Models.Base
{
    public abstract class BaseEntity
    {
 
        [Key] // Menandakan properti ini sebagai primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Menentukan bahwa nilai Id di-generate secara otomatis oleh database
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        [Column("UpdatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        [Column("CreatedBy", TypeName = "nvarchar(50)")]
        public required string CreatedBy { get; set; }

        [StringLength(50)]
        [Column("UpdatedBy", TypeName = "nvarchar(50)")]
        public string? UpdatedBy { get; set; }

        [Column("IsDeleted", TypeName = "bit")]
        public bool IsDeleted { get; set; } = false;
    }
}