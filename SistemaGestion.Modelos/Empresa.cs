using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        [MaxLength(60, ErrorMessage ="El nombre debe ser maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ruc Requerido")]
        public int Ruc { get; set; }

        [Required(ErrorMessage = "Email Requerido")]
        [MaxLength(60, ErrorMessage = "Email debe ser maximo 60 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefono Requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Actividad Requerido")]
        [MaxLength(50, ErrorMessage = "Actividad debe ser maximo 50 caracteres")]
        public string Actividad { get; set; }

        [Required(ErrorMessage = "Numero de Colaboradores de la empresa Requerido")]
        public int NEmpleados { get; set; }

        [Required(ErrorMessage = "Estado Requerido")]
        public bool Estado { get; set; }
    }
}
