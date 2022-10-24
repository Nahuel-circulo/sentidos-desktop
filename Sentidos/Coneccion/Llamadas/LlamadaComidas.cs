using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentidos.Coneccion.Entidades;

namespace Sentidos.Coneccion.Llamadas
{
    internal class LlamadaComidas
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<Comida> Results { get; set; }
    }
}
