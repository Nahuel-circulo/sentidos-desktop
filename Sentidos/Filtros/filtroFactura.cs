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
    public partial class filtroFactura : UserControl
    {
        public filtroFactura()
        {
            InitializeComponent();
            colorBotonGenerarFactura();


        }

        public void colorBotonGenerarFactura()
        {
            BotonColor botonColor = new BotonColor();
            botonColor.colorBotonGeneral(buttonGenerarFactura);
        }
        





    }
}
