namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Giá")]
        public int? UnitCost { get; set; }
        [Display(Name = "Số luọng còn")]

        public int? Quantity { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        [Display(Name = "Loại sản phẩm")]
        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }//khoÁ ngoại 
    }
}
