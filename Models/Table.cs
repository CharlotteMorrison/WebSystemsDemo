namespace OspreyOlympiansGold.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        public int Purchase_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Plan { get; set; }

        public decimal Cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int User_Id { get; set; }
    }
}
