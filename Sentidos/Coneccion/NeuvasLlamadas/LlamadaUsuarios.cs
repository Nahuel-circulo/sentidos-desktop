using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.NeuvasLlamadas
{
    internal class LlamadaUsuarios
    {
        public List<Doc3> Docs { get; set; }
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

    public partial class Doc3
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
