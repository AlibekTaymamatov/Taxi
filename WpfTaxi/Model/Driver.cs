namespace WpfTaxi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int Driver_ID { get; set; }

        public int Model_FK { get; set; }

        public int Color_FK { get; set; }

        [Required]
        [StringLength(50)]
        public string number_car { get; set; }

        [Required]
        [StringLength(15)]
        public string Driver_phone_number { get; set; }

        [Required]
        [StringLength(50)]
        public string Driver_name { get; set; }

        public virtual Color Color { get; set; }

        public virtual Model Model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
