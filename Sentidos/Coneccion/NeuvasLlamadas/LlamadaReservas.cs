using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.NeuvasLlamadas
{
    public partial class LlamadaReservas
    {
        public List<Doc2> Docs { get; set; }
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

    public partial class Doc2
    {
        public string Id { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public string Horario { get; set; }
        public bool Confirmado { get; set; }
        public bool Cancelado { get; set; }
        public long Comensales { get; set; }
        public User User { get; set; }
        public Mesa Mesa { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class Mesa
    {
        public string Id { get; set; }
        public long Nro_Mesa { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class User
    {
        public string Id { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string Name { get; set; }
    }
}
