namespace Kursachi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
        }

        public int Id { get; set; }

        public int Weight { get; set; }

        public int TypeOfProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }

        public virtual TypeOfContainer TypeOfContainer { get; set; }

        public virtual TypeOfProduct TypeOfProduct { get; set; }
    }
}
