namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? catalog_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name { get; set; }

        public decimal? price { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        public int? discount { get; set; }

        [StringLength(50)]
        public string image_link { get; set; }

        [StringLength(50)]
        public string image_list { get; set; }
    }
}
