using Sentidos.Coneccion;
using Sentidos.Coneccion.Llamadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentidos
{
    public partial class filtroPrecios : UserControl
    {
        public filtroPrecios()
        {
            InitializeComponent();
            colorBoton();
        }

        private void btnPreciosRestaurante_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
            

            labelListaPrecios.Text = "Lista de precios del restaurante:";
            dataGridViewPrecios.Rows.Clear();
            traerComida('f'); 
        }

        private async void btnPreciosCasa_Té_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
           

            labelListaPrecios.Text = "Lista de precios de la Casa de Té:";
            dataGridViewPrecios.Rows.Clear();
            traerComida('t');


        }

        private void flowLayoutPanelFiltroPrecios_Paint(object sender, PaintEventArgs e)
        {

            //mostrar los precios de la casa de té correspondientes aquí
        }


        public void colorBoton()
        {
            Button[] arrayBoton = { btnPreciosRestaurante, btnPreciosCasa_Té };
            BotonColor botonColor = new BotonColor();
            for (int i = 0; i < arrayBoton.Length; i++)
            {
                botonColor.colorBotonMenu(arrayBoton[i]);
            }

        }
        private async void traerComida(char x)
        {
            LlamadaComidas listaComidas = await Conexion.TraerComidas(x);
            foreach (var item in listaComidas.Results)
            {

                dataGridViewPrecios.Rows.Add(item.Name,item.Description,item.Price);
                   
            }
            
            //dataGridViewPrecios.DataSource = listaComidas.Results;
            dataGridViewPrecios.Refresh();
        }
    }
}
