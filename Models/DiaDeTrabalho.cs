using IEL_Application.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEL_Application.Models
{
    public class DiaDeTrabalho
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DiaDaSemanaEnum DiaDaSemana { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFim { get; set; }

        public int TempoDescanso { get; set; }

        public Profissional Profissional { get; set; }

        public Guid ProfissionalId { get; set; }

    }
}
