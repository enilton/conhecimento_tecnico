using IEL_Application.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEL_Application.Models
{
    public class Profissional
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]        
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public bool Habilitacao { get; set; }

        public string CategoriaHabilitacao { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public LinguaEstrangeiraEnum LinguaEstrangeira { get; set; }

        public Endereco Endereco { get; set; }

        public CargoEnum Cargo { get; set; }

        public string SalarioProposto { get; set; }   

    }

    
}
