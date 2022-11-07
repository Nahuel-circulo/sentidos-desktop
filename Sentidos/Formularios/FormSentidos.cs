using Sentidos.Coneccion.Entidades;
using Sentidos.Coneccion.NuevasEntidades;
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
    public partial class FormSentidos : Form
    {
        private Trabajador Personal;
        public FormSentidos(Trabajador personal)
        {
            InitializeComponent();
            
            
            this.Personal= personal;
            labelNombreUsuario.Text = personal.Name;
            labelNombreUsuario.Refresh();
            
        }

        private void flowLayoutPanelSentidos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPedido_Click_1(object sender, EventArgs e)
        {
            filtroPedidos fp = new filtroPedidos();
            traerFiltros(fp);
        }

        //utilidades

        private void traerFiltros(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            panelFiltros.Controls.Clear();
            panelFiltros.Controls.Add(filtro);
            filtro.BringToFront();

        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            filtroPrecios fp = new filtroPrecios();
            traerFiltros(fp);
        }

        private void linkLabelDevStation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelDevStation.LinkVisited = true; 
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://devstation213396337.wordpress.com/", UseShellExecute = true });
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            filtroListados fp = new filtroListados();
            traerFiltros(fp);
        }

        //boton Reservas
        private void button1_Click(object sender, EventArgs e)
        {
            filtroReservas fp = new filtroReservas();
            traerFiltros(fp);
        }

        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            filtroFactura fp = new filtroFactura();
            traerFiltros(fp);
            
        }
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            FiltroIngresos fp = new FiltroIngresos();
            traerFiltros(fp);
        }
        
    }
}
