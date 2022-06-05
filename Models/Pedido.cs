using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TheCapitalBurguer.Models
{
    [Table("Pedido")]
    public partial class Pedido
    {
        [Key]
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Dirección { get; set; }
        public double? Telefono { get; set; }
        [StringLength(100)]
        public string Productos { get; set; }
    }
}
