using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNetCore.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(maximumLength: 256, ErrorMessage = "La descripción no debe exceder los 256 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
