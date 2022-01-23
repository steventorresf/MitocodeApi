using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EvaluacionFinal.Entities
{
    [Table("Producto", Schema = "dbo")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        [Required, StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public bool Habilitado { get; set; }
    }
}
