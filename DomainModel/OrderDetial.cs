namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetial
    {
        [Key]
        public int OrderDetailsID { get; set; }

        public int FoodID { get; set; }

        public int OrderID { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public virtual Food Food { get; set; }

        public virtual Order Order { get; set; }
    }
}
