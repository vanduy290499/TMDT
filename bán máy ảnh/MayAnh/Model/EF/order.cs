namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order")]
    public partial class order
    {
        public int? transaction_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? product_id { get; set; }

        public int? qty { get; set; }

        public decimal? amount { get; set; }

        [Column(TypeName = "text")]
        public string data { get; set; }

        public byte? status { get; set; }
    }
}
