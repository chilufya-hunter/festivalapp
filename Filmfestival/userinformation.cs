namespace Filmfestival
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.userinformation")]
    public partial class userinformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string surname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string password { get; set; }

        [StringLength(25)]
        public string organisation { get; set; }
    }
}
