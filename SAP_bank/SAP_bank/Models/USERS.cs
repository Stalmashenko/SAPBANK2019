namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        public int ID { get; set; }

        public int? ID_CLIENTS { get; set; }

        [Required]
        [StringLength(20)]
        public string LOGIN { get; set; }

        [Required]
        [StringLength(40)]
        public string PASSWORD { get; set; }

        public virtual CLIENTS CLIENTS { get; set; }
    }
}
