using Sentidos.Coneccion;
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
        }

        private async void btnPreciosRestaurante_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
            

            labelListaPrecios.Text = "Lista de precios del restaurante:";
            traerComida('f'); 
        }

        private async void btnPreciosCasa_Té_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
           

            labelListaPrecios.Text = "Lista de precios de la Casa de Té:";
            traerComida('t');


        }

        private void flowLayoutPanelFiltroPrecios_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void traerComida(char x)
        {
            ListaComidas listaComidas = await Conexion.TraerComidas(x);
            dataGridView1.DataSource = listaComidas.Results;
            dataGridView1.Refresh();
        }
    }
}
