namespace WpfTaxi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        public int Orders_ID { get; set; }

        public DateTime time { get; set; }

        public int status_orders_FK { get; set; }

        [Required]
        [StringLength(50)]
        public string mesto_otpravleniya { get; set; }

        [Required]
        [StringLength(50)]
        public string mesto_naznacheniya { get; set; }

        public int Client_FK { get; set; }

        public int Dipatcher_FK { get; set; }

        public int Driver_FK { get; set; }

        public virtual Client Client { get; set; }

        public virtual Dispatcher Dispatcher { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual status_orders status_orders { get; set; }
    }
}
