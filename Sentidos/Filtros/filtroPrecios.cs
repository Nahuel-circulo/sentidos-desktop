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
            //mostrar los precios del restaurante correspondientes aquí
            
        }

        private void btnPreciosCasa_Té_Click(object sender, EventArgs e)
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
    }
}
