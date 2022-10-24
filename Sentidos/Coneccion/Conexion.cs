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
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System;
using Newtonsoft.Json;
//using System.Text.Json.Nodes;
using System.Diagnostics;
using Sentidos.Coneccion.Entidades;
using Sentidos.Coneccion.Llamadas;

namespace Sentidos.Coneccion
{
    internal class Conexion
    {
        private const string url = "https://nahuelnp.pythonanywhere.com";

        private HttpClient Client;
        //JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public Conexion()
        {

        }
        public static async Task<LlamadaReservasPorFecha> TraerMesasReservadas()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            char c = DateTime.Now.Hour > 12 ? 'm' : 't';
            HttpResponseMessage response = await Client.GetAsync("/api/reservation/?hora=" + c + "&fecha=" + DateTime.Now.GetDateTimeFormats()[5] );
            LlamadaReservasPorFecha reservasPorFecha = null;
            if (response.IsSuccessStatusCode)
            {

                var a = response.Content.ReadAsStringAsync().Result;
                reservasPorFecha = JsonConvert.DeserializeObject<LlamadaReservasPorFecha>(a);


            }

            return reservasPorFecha;
        }
        public static async Task<LlamadaMesas> TraerMesas()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("/api/tables/");
            LlamadaMesas llamadaMesas = null;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                llamadaMesas = JsonConvert.DeserializeObject<LlamadaMesas>(a);
            }
            return llamadaMesas;
        }
        

        public static async Task<LlamadaComidas> TraerComidas(char x)
        {
            //Debug.Write("HOLA");

            LlamadaComidas listaComidas= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("api/food?category="+x);
            
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
               
                listaComidas = JsonConvert.DeserializeObject<LlamadaComidas>(a);


            }
            
            return listaComidas;
        }
        public static void enviarRecerva(Reserva r)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(r));
            var hola= Client.PostAsync("/api/reservation/",stringContent);
            Debug.Write(hola.IsFaulted);
            Debug.Write("hola");
        }

        public async static Task<LlamadaUsuario> traerUsuarios()
        {
            
            LlamadaUsuario listaUsuarios= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("api/users");
            if (response.IsSuccessStatusCode)
            {
               
                var a = response.Content.ReadAsStringAsync().Result;

                listaUsuarios = JsonConvert.DeserializeObject<LlamadaUsuario>(a);


            }
            return listaUsuarios;
        }
        public async static Task<Personal> Login(string usuario, string contraseña)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("api/personal/?username="+usuario+"&password="+contraseña);
            LlamadaLogin llamadaLogin = null;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(a);
                llamadaLogin = JsonConvert.DeserializeObject<LlamadaLogin>(a);
               
               
            }
            if(llamadaLogin.Results.Count != 0)
            {
                
                return llamadaLogin.Results[0];
            }
            return null;
        }
      
    }
}
