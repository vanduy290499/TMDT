namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        public int id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        public int idquyen { get; set; }

        public virtual Quyen Quyen { get; set; }

        public virtual Quyen Quyen1 { get; set; }
    }
}
