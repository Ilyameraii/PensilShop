namespace PensilShop.Models
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
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }

        [Required]
        public string Articul { get; set; }

        public int ProductNameId { get; set; }

        public int UnitOfMeasurementId { get; set; }

        public decimal Price { get; set; }

        public int MaxDiscount { get; set; }

        public int ManufacturerId { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        public int Discount { get; set; }

        public int Stock { get; set; }

        [Required]
        public string Description { get; set; }

        public string Photo { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual ProductName ProductName { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
