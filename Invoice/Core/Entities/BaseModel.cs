using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Entities
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "dateTime2")]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "dateTime2")]
        public DateTime FechaUltimaActualizacion { get; set; }

        public bool Eliminado { get; set; }
    }
}
