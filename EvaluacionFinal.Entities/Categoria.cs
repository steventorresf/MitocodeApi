using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EvaluacionFinal.Entities
{
    [Table("Categoria", Schema = "dbo")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        public bool Habilitado { get; set; }
    }
}
