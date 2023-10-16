namespace ProjektiLoja
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LojtaretFitue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumriFituesId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmriFitues { get; set; }
    }
}
