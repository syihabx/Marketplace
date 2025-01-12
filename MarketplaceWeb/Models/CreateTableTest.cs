using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MarketplaceWeb.Models.Base;

namespace MarketplaceWeb.Models
{
    //[Table("TestTable")] // Menentukan nama tabel di database
    public class CreateTableTest : BaseEntity
    {
        [Required(ErrorMessage = "Nama wajib diisi.")]
        [StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter.")]
        [Column("Name", TypeName = "nvarchar(100)")] // Menentukan nama kolom dan tipe data di database
        public required string Name { get; set; }

        [StringLength(500, ErrorMessage = "Deskripsi tidak boleh lebih dari 500 karakter.")]
        [Column("Description", TypeName = "nvarchar(500)")] // Menentukan nama kolom dan tipe data di database
        public required string Description { get; set; }

        [Required(ErrorMessage = "Tipe wajib diisi.")]
        [StringLength(50, ErrorMessage = "Tipe tidak boleh lebih dari 50 karakter.")]
        [Column("Type", TypeName = "nvarchar(50)")] // Menentukan nama kolom dan tipe data di database
        public required string Type { get; set; }
    }
}
