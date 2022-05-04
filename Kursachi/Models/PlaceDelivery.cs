namespace Kursachi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaceDelivery")]
    public partial class PlaceDelivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlaceDelivery()
        {
            Delivery = new HashSet<Delivery>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Where { get; set; }

        [Required]
        [StringLength(100)]
        public string From { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
