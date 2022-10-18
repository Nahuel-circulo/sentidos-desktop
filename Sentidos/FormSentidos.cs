﻿using Sentidos.Coneccion;
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
            TraerComida();
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
            // marca error: System.Diagnostics.Process.Start("https://devstation213396337.wordpress.com/");
        }

        private async void TraerComida()
        {
           
            ListaComidas comidas =await Conexion.TraerComidas();
            dataGridView1.DataSource = comidas.Results;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            filtroListados fp = new filtroListados();
            traerFiltros(fp);
        }

        private void pictureBoxLogoSentidos_Click(object sender, EventArgs e)
        {
            
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
    }
}
