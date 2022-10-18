using Sentidos.Coneccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ListaUsuarios usuarios = await Conexion.traerUsuarios();
            String usuario;
            bool Flag = false;
            int numeroUsuario = 0;
            foreach(var item in usuarios.Results)
            {
                
                Flag = item.Name == textBoxCamarero.Text ? true : false;
                numeroUsuario = item.Name == textBoxCamarero.Text ? (int)item.Id : 0;
                
            }
            if (Flag)
            {
                Reserva reserva = new Reserva();

               
                reserva.NroMesa = 5;
                reserva.UserId = 4;
                reserva.Comensales = 4;
                reserva.Horario= "M" ;
                reserva.Fecha = dateTimePicker1.Value.ToString("yyy") +"-"+ dateTimePicker1.Value.ToString("MM") + "-" + dateTimePicker1.Value.ToString("dd");

                Conexion.enviarRecerva(reserva);

            }

           


        }
    }
}
