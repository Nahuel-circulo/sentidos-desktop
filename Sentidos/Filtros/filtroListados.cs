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
    public partial class filtroListados : UserControl
    {
        public filtroListados()
        {
            InitializeComponent();

        }

        private async void btnListadoClientes_Click(object sender, EventArgs e)
        {
            dataGridViewListadosDefault.Columns.Clear();
            crearColumnasDataGridClientes();
            LlamadaUsuario usuario = await Conexion.traerUsuarios();
            foreach (var item in usuario.Results)
            {
                dataGridViewListadosDefault.Rows.Add(item.Name);
            }
        }
        private async void btnListadoMesasReservadas_Click(object sender, EventArgs e)
        {
            dataGridViewListadosDefault.Columns.Clear();
            crearColumnasDataGridMesas();
            LlamadaReservasPorFecha llamadaReservasPorFecha = await Conexion.TraerMesasReservadas();
            LlamadaMesas llamadaMesas = await Conexion.TraerMesas();
            foreach(var item in llamadaMesas.Results)
            {
                bool flag=false;
                foreach(var item2 in llamadaReservasPorFecha.Results)
                {
                    if(item.Id == item2.NroMesa)
                    {
                        flag = true;
                    }
                }
                if (flag) dataGridViewListadosDefault.Rows.Add(item.Id, "reservado");
                else dataGridViewListadosDefault.Rows.Add(item.Id, "disponible");



            }
        }

        private void crearColumnasDataGridClientes()
        {
            //creación del nombre del cliente
            DataGridViewTextBoxColumn columnNombreCliente = new DataGridViewTextBoxColumn();
            columnNombreCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnNombreCliente.HeaderText = "Nombre";
            dataGridViewListadosDefault.Columns.Add(columnNombreCliente);

            //agregar mas detalles de ser necesario


        }
        private void crearColumnasDataGridMesas()
        {

            //columna numero de mesa
            DataGridViewTextBoxColumn columnNombreMesas = new DataGridViewTextBoxColumn();
            columnNombreMesas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnNombreMesas.HeaderText = "Número de mesa";
            dataGridViewListadosDefault.Columns.Add(columnNombreMesas);

            //columna estado de mesa
            DataGridViewTextBoxColumn columnEstadoMesas = new DataGridViewTextBoxColumn();
            columnEstadoMesas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnEstadoMesas.HeaderText = "Estado";
            dataGridViewListadosDefault.Columns.Add(columnEstadoMesas);
        }

        private void btnListadoMesasReservadas_Click(object sender, EventArgs e)
        {
            dataGridViewListadosDefault.Columns.Clear();
        }

        public void colorBoton()
        {
            Button[] arrayBoton = { btnListadoMesasReservadas , btnListadoClientes };
            BotonColor botonColor = new BotonColor();
            for (int i = 0; i < arrayBoton.Length; i++)
            {
                botonColor.colorBotonMenu(arrayBoton[i]);
            }
            
        }
    }
}
