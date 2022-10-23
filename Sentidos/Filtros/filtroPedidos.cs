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
    public partial class filtroPedidos : UserControl
    {
        public filtroPedidos()
        {
            InitializeComponent();
            
        }

        private void traerFiltros(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            tableLayoutPanelPedidos.Controls.Clear();
            tableLayoutPanelPedidos.Controls.Add(filtro);
            filtro.BringToFront();

        }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            FiltroAgregarPedido filtroAgregarPedido = new FiltroAgregarPedido();
            traerFiltros(filtroAgregarPedido);
        }
    }
}
