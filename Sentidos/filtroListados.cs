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

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            dataGridViewListadosDefault.Columns.Clear();
            crearColumnasDataGridClientes();
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
            crearColumnasDataGridMesas();
        }
    }
}
