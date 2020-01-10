namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPOSIT")]
    public partial class DEPOSIT
    {
        public int ID { get; set; }

        public int? MYID { get; set; }

        public decimal? SUMMA { get; set; }

        public DateTime? DATE_DEPOSIT { get; set; }

        public decimal? STAVKA { get; set; }

        public int? DAYS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DATE_FINISH { get; set; }

        public virtual CLIENTS CLIENTS { get; set; }
    }
}
