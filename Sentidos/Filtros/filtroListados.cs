using Sentidos.Coneccion;
using Sentidos.Coneccion.Entidades;
using Sentidos.Coneccion.Llamadas;
using Sentidos.Coneccion.NeuvasLlamadas;
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
            LlamadaUsuarios usuario = await Conexion.traerUsuarios();
            foreach (var item in usuario.Docs)
            {
                dataGridViewListadosDefault.Rows.Add(item.Email);
            }
        }
        private async void btnListadoMesasReservadas_Click(object sender, EventArgs e)
        {
            dataGridViewListadosDefault.Columns.Clear();
            crearColumnasDataGridMesas();
            LlamadaReservas llamadaReservas = await Conexion.TraerMesasReservadas();           
            if(llamadaReservas.Docs.Count != 0)
            {
                foreach (var item in llamadaReservas.Docs)
                {
                    Debug.WriteLine(item.Mesa.Nro_Mesa);
                    dataGridViewListadosDefault.Rows.Add(item.User.Name, item.Mesa.Nro_Mesa);
                 
                }
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
            columnNombreMesas.HeaderText = "Usuario";
            dataGridViewListadosDefault.Columns.Add(columnNombreMesas);

            //columna estado de mesa
            DataGridViewTextBoxColumn columnEstadoMesas = new DataGridViewTextBoxColumn();
            columnEstadoMesas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnEstadoMesas.HeaderText = "Mesa";
            dataGridViewListadosDefault.Columns.Add(columnEstadoMesas);
        }

        //private void btnListadoMesasReservadas_Click(object sender, EventArgs e)
        //{
        //    dataGridViewListadosDefault.Columns.Clear();
        //}

        //public void colorBoton()
        //{
        //    Button[] arrayBoton = { btnListadoMesasReservadas , btnListadoClientes };
        //    BotonColor botonColor = new BotonColor();
        //    for (int i = 0; i < arrayBoton.Length; i++)
        //    {
        //        botonColor.colorBotonMenu(arrayBoton[i]);
        //    }
            
        //}
    }
}
