namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADDRESS")]
    public partial class ADDRESS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADDRESS()
        {
            CLIENTS = new HashSet<CLIENTS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string STATE { get; set; }

        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [Required]
        [StringLength(40)]
        public string STREET { get; set; }

        [Required]
        [StringLength(20)]
        public string HOUSE { get; set; }

        [StringLength(20)]
        public string HOUSING { get; set; }

        public int FLAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTS> CLIENTS { get; set; }
    }
}
