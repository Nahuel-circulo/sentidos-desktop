using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.NuevasEntidades
{
    public class Trabajador
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
    public partial class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
