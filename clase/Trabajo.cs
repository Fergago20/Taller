using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.clase
{
    internal class Trabajo
    {
        List<Servicio> servicios = new List<Servicio>();

        public void Agregar(Servicio servicio)
        {
            servicios.Add(servicio);
        }

        public List<Servicio> Mostrar()
        {
            return servicios;
        }
    }
}
