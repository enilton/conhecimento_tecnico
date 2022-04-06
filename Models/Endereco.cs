using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEL_Application.Models
{
    public class Endereco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public int IdentificadorUF { get; set; }  
        
        public int IdentificadorMunicipio { get; set; }

        public string CEP { get; set; }
            
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

    }
}
