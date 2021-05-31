using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Entity
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "dateTime2")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "dateTime2")]
        [DataType(DataType.DateTime)]
        public DateTime FechaUltimaActualizacion { get; set; }

        public bool Eliminado { get; set; }

        public BaseModel()
        {
            FechaCreacion = DateTime.UtcNow;
            FechaUltimaActualizacion = DateTime.UtcNow;
        }
    }
}
