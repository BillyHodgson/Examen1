using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.dbo
{
    public class DepartamentoEntity
    {
        public int Id_Departamento { get; set; }

        public string Descripcion { get; set; }

        public string Ubicacion { get; set; }

        public bool Estado { get; set; }
    }
}
