using Microsoft.VisualBasic.Logging;
using Sentidos.Coneccion;
using Sentidos.Formularios;
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
    public partial class LogIn : Form
    {
        private Personal personal;
        
        public LogIn()
        {
            InitializeComponent();
        }

        internal Personal Personal { get => personal; }

        private async void buttonAceptar_Click(object sender, EventArgs e)
        {
            personal =await Conexion.Login(textBoxNombre_Usuario.Text, textBoxContraseña.Text);
            
            if (Personal != null)
            {
                this.Close();
            }
            else
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }

    }
}
