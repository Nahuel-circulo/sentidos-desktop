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

        public static async Task<ListaComidas> TraerComidas(char x)
        {
            //Debug.Write("HOLA");

            ListaComidas listaComidas= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("api/food?category="+x);
            
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
               
                listaComidas = JsonConvert.DeserializeObject<ListaComidas>(a);


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

        public async static Task<ListaUsuarios> traerUsuarios()
        {
            ListaUsuarios listaUsuarios= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("api/users");
            if (response.IsSuccessStatusCode)
            {
               
                var a = response.Content.ReadAsStringAsync().Result;

                listaUsuarios = JsonConvert.DeserializeObject<ListaUsuarios>(a);


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
