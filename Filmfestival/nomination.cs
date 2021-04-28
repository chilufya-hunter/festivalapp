namespace Filmfestival
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nomination")]
    public partial class nomination
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_film { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string title { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string category { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal rating { get; set; }
    }
}
