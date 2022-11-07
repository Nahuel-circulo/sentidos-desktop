using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentidos.Coneccion.NeuvasLlamadas;

namespace Sentidos.Coneccion.NuevasEntidades
{
    internal class ListaDeComidas
    {
        public ListaDeComidas(Doc a)
        {
            this.docs = new List<Doc>();
            this.docs.Add(a);
        }

        public List<Doc> docs;
       public void Add()
        {
            docs.Add(docs[0]);
        }

        public void Rest()
        {
            if(docs.Count != 0)
            {
                docs.Remove(docs.Last<Doc>());
            }
            
        }
        public bool getComida(string id)
        {
            if(docs.Count == 0)
            {
                return false;
            }
             return docs[0].Id == id;
        }
       
    }
}
