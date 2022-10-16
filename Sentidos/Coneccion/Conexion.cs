using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Sentidos.Coneccion
{
    internal class Conexion
    {
        private const string url = "https://nahuelnp.pythonanywhere.com";

        private HttpClient Client;
        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public Conexion()
        {

        }
        public static async Task<Mesa> TraerMesas(int num)
        {
            Mesa Mesa = null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);


            HttpResponseMessage response = await Client.GetAsync("/api/food/" + num);
            if (response.IsSuccessStatusCode)
            {

                var a = response.Content.ReadAsStringAsync().Result;
                Mesa = JsonConvert.DeserializeObject<Mesa>(a);


            }

            return Mesa;
        }

        public static async Task<ListaComidas> TraerComidas()
        {


            ListaComidas listaComidas= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("/api/food/");
            if (response.IsSuccessStatusCode)
            {

                var a = response.Content.ReadAsStringAsync().Result;
               
                listaComidas = JsonConvert.DeserializeObject<ListaComidas>(a);


            }

            return listaComidas;
        }
      
    }
}
