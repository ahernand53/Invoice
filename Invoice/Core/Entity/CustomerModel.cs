using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Entity
{
    public class CustomerModel : BaseModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string DNI { get; set; }

        public string Direccion { get; set; }

        public string Celular { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comentarios { get; set; }
    }
}
