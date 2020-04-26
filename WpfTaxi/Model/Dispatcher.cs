namespace WpfTaxi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dispatcher")]
    public partial class Dispatcher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dispatcher()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int Dispatcher_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Dispatcher_name { get; set; }

        [Required]
        [StringLength(10)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
