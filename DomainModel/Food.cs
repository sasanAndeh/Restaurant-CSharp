namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            OrderDetials = new HashSet<OrderDetial>();
        }

        public int FoodID { get; set; }

        [Required]
        [StringLength(100)]
        public string FoodName { get; set; }

        [StringLength(500)]
        public string Ingredients { get; set; }

        public int UnitPrice { get; set; }

        public int FoodCategoryID { get; set; }

        [StringLength(500)]
        public string Picture { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetial> OrderDetials { get; set; }
    }
}
