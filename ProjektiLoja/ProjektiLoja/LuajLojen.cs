namespace ProjektiLoja
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuajLojen")]
    public partial class LuajLojen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LojtariId { get; set; }

        public int Numri_i_pare { get; set; }

        public int Numri_i_dyte { get; set; }

        public int Numri_i_trete { get; set; }

        public int Numri_i_katert { get; set; }

        public int Numri_i_peste { get; set; }

        public int Numri_i_gjashte { get; set; }

        public int Numri_i_shtate { get; set; }
    }
}
