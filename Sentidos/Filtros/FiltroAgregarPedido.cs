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
    public partial class FiltroAgregarPedido : UserControl
    {
        public FiltroAgregarPedido()
        {
            InitializeComponent();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            limpiarFiltro();
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            limpiarFiltro();
        }

        private void limpiarFiltro()
        {
            
            tableLayoutPanelAgregarQuitar.Visible = false;
            tableLayoutPanelEliminarRealizar.Visible = false;
            tableLayoutPanelListaComida.Visible = false;
            tableLayoutPanelListaPedido.Visible = false;
        }
    }
}
