using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion
{
    internal class Comida
    {
        private long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        private Uri Image { get; set; }
        public string Category { get; set; }
    
    }
}
