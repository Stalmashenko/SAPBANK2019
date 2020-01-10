namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BALANCE")]
    public partial class BALANCE
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MYCOUNT { get; set; }

        [Column("BALANCE")]
        public decimal? BALANCE1 { get; set; }
    }
}
