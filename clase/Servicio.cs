using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.clase
{
    public struct Servicio
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Matricula { get; set; }
        public string Reparacion { get; set; }
        private string seguro;
        public string Seguro 
        { get
            {
                return string.IsNullOrEmpty(seguro) ? "Sin seguro" : seguro;
            }
            set
            {
                seguro = value;
            }
        }
    }
}
