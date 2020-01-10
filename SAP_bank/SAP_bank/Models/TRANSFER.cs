namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANSFER")]
    public partial class TRANSFER
    {
        public int ID { get; set; }

        public int? MYID { get; set; }

        [StringLength(20)]
        public string TOIDBALANCE { get; set; }

        public decimal? SUMMA { get; set; }

        public DateTime? DATE_TRANSFER { get; set; }

        public virtual CLIENTS CLIENTS { get; set; }
    }
}
