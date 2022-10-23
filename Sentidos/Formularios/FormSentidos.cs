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

namespace Sentidos
{
    public partial class FormSentidos : Form
    {
        public FormSentidos()
        {
            InitializeComponent();
            ejecutarVista();

            
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


        //Colores y vistas

        private void ejecutarVista()
        {
            colorMenu();
            funcionalidadColorBotones();
        }
        private void colorMenu()
        {
            tableLayoutPanel_menuSentidos.BackColor = ColorTranslator.FromHtml("#1a2223");
            labelNombreUsuario.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
            labelNombreUsuario.ForeColor = Color.White;


        }

        private void funcionalidadColorBotones()
        {
            
            Button[] arrayBotones = {btnPedido,button1,btnListados,btnIngresos, btnPrecios,buttonGenerarFactura, btnSentidos };

            for (int i = 0; i < arrayBotones.Length; i++)
            {
                BotonColor botonColor = new BotonColor();
                botonColor.colorBotonMenu(arrayBotones[i]);
               
                if (arrayBotones[i] == btnSentidos)
                {
                    arrayBotones[i].FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1a2223");
                    arrayBotones[i].FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#1a2223");
                }

            }
        }

        
    }
}
