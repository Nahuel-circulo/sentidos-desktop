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
            colorBotonAceptarPedido();
        }

        public void colorBotonAceptarPedido()
        {
            BotonColor botonColor = new BotonColor();
            botonColor.colorBotonGeneral(btnAceptarPedido);
        }
    }
}
