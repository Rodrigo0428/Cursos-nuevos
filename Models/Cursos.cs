using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cursos_nuevos.Models
{
    public class Cursos
    {
         public int Id { get; set; }

        [Display(Name = "Nombre del curso")]
        [Required]
        public string? Nombre { get; set; }

        [Display(Name = "Descripción del curso")]
        [Required]
        public string? Descripcion { get; set; }

        [Display(Name = "Duración del curso (horas)")]
        [Required]
        public int Duracion { get; set; }

        [Display(Name = "Fecha de inicio del curso")]
        [Required]
        public DateTime FechaInicio { get; set; }

        public List<Tema> Temas { get; set; }

    public Cursos()
       {
         Temas = new List<Tema>();
          }
     }
     
      public class Tema
      {
         public int Id { get; set; }
          [Display(Name = "Nombre del tema")]
         [Required]
         public string? Nombre { get; set; }

         public int CursoId { get; set; }

          public Cursos? Cursos { get; set; }
     }
    }
