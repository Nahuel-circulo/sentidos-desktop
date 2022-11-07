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

using Sentidos.Coneccion.NeuvasLlamadas;
using Sentidos.Coneccion.NuevasEntidades;


namespace Sentidos.Coneccion
{
    internal class Conexion
    {
        private const string url = "https://payloadback-production.up.railway.app";

        private HttpClient Client;
        //JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public Conexion()
        {

        }
        public static async Task<LlamadaReservas> TraerMesasReservadas()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            char c = DateTime.Now.Hour > 12 ? 'M' : 'N';
//            HttpResponseMessage response = await Client.GetAsync("/api/reservations?where[fecha][equals]=" + DateTime.Now.GetDateTimeFormats()[5] + "&where[horario][equals]="+c);
            HttpResponseMessage response = await Client.GetAsync("/api/reservations?where[fecha][equals]=2022-11-05&where[horario][equals]=M");

            LlamadaReservas reservasPorFecha = null;
            if (response.IsSuccessStatusCode)
            {

                var a = response.Content.ReadAsStringAsync().Result;
                reservasPorFecha = JsonConvert.DeserializeObject<LlamadaReservas>(a);


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

        //Terminado
        public static async Task<LlamadaComidasDos> TraerComidas(char x)
        {
           

            LlamadaComidasDos listaComidas= null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            if (x == 't')
            { 
                HttpResponseMessage response = await Client.GetAsync("/api/producto?where[categoria][equals]=6362d378c20c424d4b387d8b");


                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
               
                    listaComidas = JsonConvert.DeserializeObject<LlamadaComidasDos>(a);


                }
            
                return listaComidas;
            }
            if (x == 'a')
            {
                HttpResponseMessage response = await Client.GetAsync("/api/producto/");


                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;

                    listaComidas = JsonConvert.DeserializeObject<LlamadaComidasDos>(a);


                }

                return listaComidas;
            }
            if (x == 'f')
            {
                HttpResponseMessage response = await Client.GetAsync("/api/producto?where[categoria][equals]=6362d349c20c424d4b387d6c");


                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;

                    listaComidas = JsonConvert.DeserializeObject<LlamadaComidasDos>(a);


                }

                return listaComidas;
            } else return null;

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

        public async static Task<LlamadaUsuarios> traerUsuarios()
        {

            LlamadaUsuarios listaUsuarios = null;
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("/api/users");
            if (response.IsSuccessStatusCode)
            {
               
                var a = response.Content.ReadAsStringAsync().Result;

                listaUsuarios = JsonConvert.DeserializeObject<LlamadaUsuarios>(a);


            }
            return listaUsuarios;
        }

        //treminados
        public async static Task<Trabajador> Login(string usuario, string contraseña)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await Client.GetAsync("/api/personal?where[email][equals]=" + usuario + "&where[password][equals]=" + contraseña);
            //LlamadaLogin llamadaLogin = null;
            NeuvasLlamadas.LLamadaLogin llamadaLogin = null;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(a);
                llamadaLogin = JsonConvert.DeserializeObject<NeuvasLlamadas.LLamadaLogin>(a);
               
               
            }
            if(llamadaLogin.TotalDocs != 0)
            {
                
                return llamadaLogin.Docs[0];
            }
            return null;
        }
      
    }
}
