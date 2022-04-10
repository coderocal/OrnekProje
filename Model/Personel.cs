namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel
    {
        public int PersonelId { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTarih { get; set; }
    }
}
