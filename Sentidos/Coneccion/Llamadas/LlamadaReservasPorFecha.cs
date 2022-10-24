﻿using Sentidos.Coneccion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.Llamadas
{
    internal class LlamadaReservasPorFecha
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<Reserva> Results { get; set; }
    }
}
