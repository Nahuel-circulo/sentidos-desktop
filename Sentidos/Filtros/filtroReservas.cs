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
    public partial class filtroReservas : UserControl
    {
        public filtroReservas()
        {
            InitializeComponent();
            colorBotonAceptar();
        }


        public void colorBotonAceptar()
        {
            BotonColor botonColor = new BotonColor();
            botonColor.colorBotonGeneral(btnAceptar);
        }
    }
}
