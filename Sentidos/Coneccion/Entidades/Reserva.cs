using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.Entidades
{
    internal class Reserva
    {
        public int NroMesa { get; set; }
        public string Horario { get; set; }
        public string Fecha { get; set; }
        public bool Confirmado { get; set; }
        public int Comensales { get; set; }
        public int UserId { get; set; }
        public bool Cancelado { get; set; }
    }
}
