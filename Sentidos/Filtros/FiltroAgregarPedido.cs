using Sentidos.Coneccion.NeuvasLlamadas;
using Sentidos.Coneccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentidos.Coneccion.NeuvasLlamadas;
using Sentidos.Coneccion;
using Sentidos.Coneccion.NuevasEntidades;

namespace Sentidos
{
    public partial class FiltroAgregarPedido : UserControl
    {
        private List<ListaDeComidas> ListaCompra;
        
        //private List<Doc> ListaTodasComidas;
        public FiltroAgregarPedido()
        {
            InitializeComponent();
            dataGridViewListaComida.Columns.Add("Nombre", "Nombre");
            dataGridViewListaComida.Columns.Add("ID", "ID");
            dataGridViewListaComida.Columns.Add("Precio", "Precio");

            dataGridViewListaPedido.Columns.Add("Nombre", "Nombre");
            dataGridViewListaPedido.Columns.Add("ID", "ID");
            dataGridViewListaPedido.Columns.Add("Precio", "Precio");
            dataGridViewListaPedido.Columns.Add("Cantidad", "Cantida");
            TraerComidas();
            ListaCompra = new List<ListaDeComidas>();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaComida.SelectedRows.Count != 0)
            {
                if(contien((string)dataGridViewListaComida.SelectedRows[0].Cells[1].Value))
                {
                    abumentar((string)dataGridViewListaComida.SelectedRows[0].Cells[1].Value);
                }
                else
                {
                    Doc doc = new Doc();
                    doc.Id = (string)dataGridViewListaComida.SelectedRows[0].Cells[1].Value;
                    doc.Name = (string)dataGridViewListaComida.SelectedRows[0].Cells[0].Value;
                    doc.Price = (long)dataGridViewListaComida.SelectedRows[0].Cells[2].Value;
                    ListaCompra.Add(new ListaDeComidas(doc));

                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaPedido.SelectedRows.Count != 0)
            {
                decrementar((string)dataGridViewListaPedido.SelectedRows[0].Cells[1].Value);
            }

           
        }

        private void FiltroAgregarPedido_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelEliminarRealizar_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void TraerComidas()
        {
            LlamadaComidasDos listaComidas = await Conexion.TraerComidas('a');
            
            foreach (var item in listaComidas.Docs)
            {
                dataGridViewListaComida.Rows.Add(item.Name, item.Id, item.Price);

            }
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            LlamadaComidasDos listaComidas = await Conexion.TraerComidas('t');

            foreach (var item in listaComidas.Docs)
            {

                dataGridViewListaComida.Rows.Add(item.Name, item.Id, item.Price);
                

            }
        }
        private bool EncontrarId(string id)
        {
            foreach (DataRow item in dataGridViewListaPedido.Rows )
            {
                if(id == item[2])
                {
                    return true;
                }
            }
            return false;
        }
        private bool contien(string id)
        {
            foreach(ListaDeComidas item in ListaCompra)
            {
                if (item.getComida(id))
                {
                    return true;
                }
            }
                 return false;
        }

        private void abumentar(string id)
        {
            foreach (ListaDeComidas item in ListaCompra)
            {
                if (item.getComida(id))
                {
                    item.Add();
                }
            }
            dataGridViewListaPedido.Rows.Clear();

            foreach (ListaDeComidas item in ListaCompra)
            {
                if (item.docs.Count != 0)
                {
                    dataGridViewListaPedido.Rows.Add(item.docs[0].Name, item.docs[0].Id, item.docs.Count);

                }

            }
        }
        private void decrementar(string id)
        {
            foreach (ListaDeComidas item in ListaCompra)
            {
                if (item.getComida(id))
                {
                    item.Rest();
                }
            }
            dataGridViewListaPedido.Rows.Clear();

            foreach (ListaDeComidas item in ListaCompra)
            {
                if(item.docs.Count != 0) 
                { 
                    dataGridViewListaPedido.Rows.Add(item.docs[0].Name, item.docs[0].Id, item.docs.Count);
                }
            }
        }

    }
}
