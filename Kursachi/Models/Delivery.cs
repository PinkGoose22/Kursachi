namespace Kursachi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Delivery")]
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
        }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int TypeOfContainerId { get; set; }

        public int DeliveryWaysId { get; set; }

        public DateTime TimeOfDelivery { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }

        public int PlaceDeliveryId { get; set; }

        public virtual Company Company { get; set; }

        public virtual DeliveryWays DeliveryWays { get; set; }

        public virtual PlaceDelivery PlaceDelivery { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
    }
}
