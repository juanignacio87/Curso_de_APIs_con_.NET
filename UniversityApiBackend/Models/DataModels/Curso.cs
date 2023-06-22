using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso
    {
        [Required, StringLength(50)]
        
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(280)]

        public string DescripcionCorta { get; set; } = string.Empty;

        [Required]

        public string DescripcionLarga { get; set; } = string.Empty;

        [Required]

        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required]

        public string Objetivos { get; set; } = string.Empty;

        [Required]

        public string Requisitos { get; set;} = string.Empty;

        [Required]

        public Nivel nivel { get; set; }

        public enum Nivel { Básico, Intermedio, Avanzado};
    }
}
