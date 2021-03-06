namespace Kursachi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryProduct")]
    public partial class DeliveryProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int DeliveryId { get; set; }

        public int Quantity { get; set; }

        public virtual Delivery Delivery { get; set; }

        public virtual Product Product { get; set; }
    }
}
