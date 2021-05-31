using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Entity
{
    public class UserModel : BaseModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Required]
        [Compare("Contrasena")]
        [DataType(DataType.Password)]
        public string ConfirmacionContrasena { get; set; }
    }
}
