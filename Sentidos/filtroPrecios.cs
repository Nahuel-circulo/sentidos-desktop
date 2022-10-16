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

        private void btnPreciosRestaurante_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
            listViewPrecios.Items.Clear();

            labelListaPrecios.Text = "Lista de precios del restaurante:";
            listViewPrecios.Items.Add("Se mostrará la lista de precios del Restaurante desde la base de datos.");
        }

        private void btnPreciosCasa_Té_Click(object sender, EventArgs e)
        {
            //para que quede as lindo por ahora
            listViewPrecios.Items.Clear();

            labelListaPrecios.Text = "Lista de precios de la Casa de Té:";
            listViewPrecios.Items.Add("Se mostrará la lista de precios de la Casa de Té desde la base de datos.");

        }
    }
}
