namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public byte? status { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string user_mail { get; set; }

        [StringLength(50)]
        public string user_phone { get; set; }

        public decimal? amuont { get; set; }

        [StringLength(50)]
        public string payment { get; set; }

        [Column(TypeName = "text")]
        public string payment_info { get; set; }

        [StringLength(50)]
        public string message { get; set; }

        [StringLength(50)]
        public string security { get; set; }
    }
}
