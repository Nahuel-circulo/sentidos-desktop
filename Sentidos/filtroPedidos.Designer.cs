namespace Sentidos
{
    partial class filtroPedidos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpCamarero_mesa = new System.Windows.Forms.TableLayoutPanel();
            this.labelCamarero = new System.Windows.Forms.Label();
            this.textBoxCamarero = new System.Windows.Forms.TextBox();
            this.labelNumero_mesa = new System.Windows.Forms.Label();
            this.numericUpDownNumero_mesa = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.labelPedidos = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.ColumnPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTamañoPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.flpPedidos.SuspendLayout();
            this.tlpCamarero_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero_mesa)).BeginInit();
            this.tableLayoutPanelPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPedidos
            // 
            this.flpPedidos.Controls.Add(this.tlpCamarero_mesa);
            this.flpPedidos.Controls.Add(this.tableLayoutPanelPedidos);
            this.flpPedidos.Controls.Add(this.tableLayoutPanel1);
            this.flpPedidos.Location = new System.Drawing.Point(0, 0);
            this.flpPedidos.Name = "flpPedidos";
            this.flpPedidos.Size = new System.Drawing.Size(967, 532);
            this.flpPedidos.TabIndex = 0;
            // 
            // tlpCamarero_mesa
            // 
            this.tlpCamarero_mesa.ColumnCount = 5;
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.22222F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.77778F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tlpCamarero_mesa.Controls.Add(this.labelCamarero, 0, 0);
            this.tlpCamarero_mesa.Controls.Add(this.textBoxCamarero, 1, 0);
            this.tlpCamarero_mesa.Controls.Add(this.labelNumero_mesa, 2, 0);
            this.tlpCamarero_mesa.Controls.Add(this.numericUpDownNumero_mesa, 3, 0);
            this.tlpCamarero_mesa.Location = new System.Drawing.Point(3, 3);
            this.tlpCamarero_mesa.Name = "tlpCamarero_mesa";
            this.tlpCamarero_mesa.RowCount = 1;
            this.tlpCamarero_mesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCamarero_mesa.Size = new System.Drawing.Size(964, 84);
            this.tlpCamarero_mesa.TabIndex = 0;
            // 
            // labelCamarero
            // 
            this.labelCamarero.AutoSize = true;
            this.labelCamarero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCamarero.Location = new System.Drawing.Point(3, 0);
            this.labelCamarero.Name = "labelCamarero";
            this.labelCamarero.Size = new System.Drawing.Size(157, 84);
            this.labelCamarero.TabIndex = 1;
            this.labelCamarero.Text = "Camarero:";
            this.labelCamarero.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxCamarero
            // 
            this.textBoxCamarero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCamarero.Location = new System.Drawing.Point(166, 58);
            this.textBoxCamarero.Name = "textBoxCamarero";
            this.textBoxCamarero.Size = new System.Drawing.Size(281, 23);
            this.textBoxCamarero.TabIndex = 0;
            this.textBoxCamarero.Text = "Introduzca su nombre";
            this.textBoxCamarero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumero_mesa
            // 
            this.labelNumero_mesa.AutoSize = true;
            this.labelNumero_mesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumero_mesa.Location = new System.Drawing.Point(453, 0);
            this.labelNumero_mesa.Name = "labelNumero_mesa";
            this.labelNumero_mesa.Size = new System.Drawing.Size(190, 84);
            this.labelNumero_mesa.TabIndex = 2;
            this.labelNumero_mesa.Text = "Número de mesa:";
            this.labelNumero_mesa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // numericUpDownNumero_mesa
            // 
            this.numericUpDownNumero_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumero_mesa.Location = new System.Drawing.Point(649, 58);
            this.numericUpDownNumero_mesa.Name = "numericUpDownNumero_mesa";
            this.numericUpDownNumero_mesa.Size = new System.Drawing.Size(119, 23);
            this.numericUpDownNumero_mesa.TabIndex = 3;
            this.numericUpDownNumero_mesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanelPedidos
            // 
            this.tableLayoutPanelPedidos.ColumnCount = 3;
            this.tableLayoutPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46199F));
            this.tableLayoutPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.53801F));
            this.tableLayoutPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanelPedidos.Controls.Add(this.labelPedidos, 1, 0);
            this.tableLayoutPanelPedidos.Controls.Add(this.dataGridViewPedidos, 1, 1);
            this.tableLayoutPanelPedidos.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanelPedidos.Name = "tableLayoutPanelPedidos";
            this.tableLayoutPanelPedidos.RowCount = 2;
            this.tableLayoutPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.27957F));
            this.tableLayoutPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.72043F));
            this.tableLayoutPanelPedidos.Size = new System.Drawing.Size(964, 289);
            this.tableLayoutPanelPedidos.TabIndex = 1;
            // 
            // labelPedidos
            // 
            this.labelPedidos.AutoSize = true;
            this.labelPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPedidos.Location = new System.Drawing.Point(100, 0);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(749, 52);
            this.labelPedidos.TabIndex = 0;
            this.labelPedidos.Text = "Pedidos:";
            this.labelPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlato,
            this.ColumnTamañoPlato,
            this.ColumnCantidad});
            this.dataGridViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(100, 55);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(749, 231);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // ColumnPlato
            // 
            this.ColumnPlato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPlato.HeaderText = "Plato";
            this.ColumnPlato.Name = "ColumnPlato";
            // 
            // ColumnTamañoPlato
            // 
            this.ColumnTamañoPlato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTamañoPlato.HeaderText = "Tamaño";
            this.ColumnTamañoPlato.Name = "ColumnTamañoPlato";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.12544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.87456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptarPedido, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 88);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptarPedido.Location = new System.Drawing.Point(696, 17);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(155, 48);
            this.btnAceptarPedido.TabIndex = 0;
            this.btnAceptarPedido.Text = "Aceptar";
            this.btnAceptarPedido.UseVisualStyleBackColor = true;
            // 
            // filtroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpPedidos);
            this.Name = "filtroPedidos";
            this.Size = new System.Drawing.Size(967, 532);
            this.flpPedidos.ResumeLayout(false);
            this.tlpCamarero_mesa.ResumeLayout(false);
            this.tlpCamarero_mesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero_mesa)).EndInit();
            this.tableLayoutPanelPedidos.ResumeLayout(false);
            this.tableLayoutPanelPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpPedidos;
        private TableLayoutPanel tlpCamarero_mesa;
        private Label labelCamarero;
        private TextBox textBoxCamarero;
        private Label labelNumero_mesa;
        private NumericUpDown numericUpDownNumero_mesa;
        private TableLayoutPanel tableLayoutPanelPedidos;
        private Label labelPedidos;
        private DataGridView dataGridViewPedidos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAceptarPedido;
        private DataGridViewTextBoxColumn ColumnPlato;
        private DataGridViewTextBoxColumn ColumnTamañoPlato;
        private DataGridViewTextBoxColumn ColumnCantidad;
    }
}
