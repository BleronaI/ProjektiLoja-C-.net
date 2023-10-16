namespace ProjektiLoja
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lojtari")]
    public partial class Lojtari
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Emri { get; set; }

        [Required]
        [StringLength(50)]
        public string Mbiemri { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataELindjes { get; set; }

        [Required]
        [StringLength(50)]
        public string Qyteti { get; set; }

        public int LuajId { get; set; }
    }
}
