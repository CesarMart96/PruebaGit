using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TheCapitalBurguer.Models
{
    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Precio { get; set; }
    }
}
