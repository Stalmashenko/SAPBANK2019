namespace SAP_bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTS()
        {
            DEPOSIT = new HashSet<DEPOSIT>();
            TRANSFER = new HashSet<TRANSFER>();
            USERS = new HashSet<USERS>();
        }

        public int ID { get; set; }

        public int? ID_BALANCE { get; set; }
        public virtual BALANCE BALANCE { get; set; }

        public int? ID_ADDRESS { get; set; }

        [Required]
        [StringLength(20)]
        public string SURNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string FATHERSNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string ID_PASSPORT { get; set; }

        [Column(TypeName = "date")]
        public DateTime BDAY { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        [Required]
        [StringLength(20)]
        public string PHONE { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPOSIT> DEPOSIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER> TRANSFER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERS> USERS { get; set; }
    }
}
