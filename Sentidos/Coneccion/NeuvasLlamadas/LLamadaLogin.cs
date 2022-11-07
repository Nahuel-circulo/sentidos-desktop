using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentidos.Coneccion.NuevasEntidades;

namespace Sentidos.Coneccion.NeuvasLlamadas
{
    internal class LLamadaLogin
    {        
        public List<Trabajador> Docs { get; set; }
        public long TotalDocs { get; set; }
        public long Limit { get; set; }
        public long TotalPages { get; set; }
        public long Page { get; set; }
        public long PagingCounter { get; set; }
        public bool HasPrevPage { get; set; }
        public bool HasNextPage { get; set; }
        public object PrevPage { get; set; }
        public object NextPage { get; set; }
        
    }
}
