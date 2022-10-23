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
            this.numericUpDownNumero_mesa = new System.Windows.Forms.NumericUpDown();
            this.labelNumero_mesa = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.tableLayoutPanelPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.flpPedidos.SuspendLayout();
            this.tlpCamarero_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero_mesa)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPedidos
            // 
            this.flpPedidos.Controls.Add(this.tlpCamarero_mesa);
            this.flpPedidos.Controls.Add(this.tableLayoutPanelPedidos);
            this.flpPedidos.Location = new System.Drawing.Point(0, 0);
            this.flpPedidos.Name = "flpPedidos";
            this.flpPedidos.Size = new System.Drawing.Size(967, 532);
            this.flpPedidos.TabIndex = 0;
            // 
            // tlpCamarero_mesa
            // 
            this.tlpCamarero_mesa.ColumnCount = 5;
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.42359F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.57641F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tlpCamarero_mesa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpCamarero_mesa.Controls.Add(this.numericUpDownNumero_mesa, 1, 1);
            this.tlpCamarero_mesa.Controls.Add(this.labelNumero_mesa, 0, 1);
            this.tlpCamarero_mesa.Controls.Add(this.btnAgregarPedido, 3, 1);
            this.tlpCamarero_mesa.Location = new System.Drawing.Point(3, 3);
            this.tlpCamarero_mesa.Name = "tlpCamarero_mesa";
            this.tlpCamarero_mesa.RowCount = 2;
            this.tlpCamarero_mesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCamarero_mesa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpCamarero_mesa.Size = new System.Drawing.Size(964, 82);
            this.tlpCamarero_mesa.TabIndex = 0;
            // 
            // numericUpDownNumero_mesa
            // 
            this.numericUpDownNumero_mesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumero_mesa.Location = new System.Drawing.Point(206, 56);
            this.numericUpDownNumero_mesa.Name = "numericUpDownNumero_mesa";
            this.numericUpDownNumero_mesa.Size = new System.Drawing.Size(164, 23);
            this.numericUpDownNumero_mesa.TabIndex = 3;
            this.numericUpDownNumero_mesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumero_mesa
            // 
            this.labelNumero_mesa.AutoSize = true;
            this.labelNumero_mesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumero_mesa.Location = new System.Drawing.Point(3, 28);
            this.labelNumero_mesa.Name = "labelNumero_mesa";
            this.labelNumero_mesa.Size = new System.Drawing.Size(197, 54);
            this.labelNumero_mesa.TabIndex = 2;
            this.labelNumero_mesa.Text = "Número de mesa:";
            this.labelNumero_mesa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPedido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Location = new System.Drawing.Point(604, 31);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(173, 48);
            this.btnAgregarPedido.TabIndex = 4;
            this.btnAgregarPedido.Text = "Agregar pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // tableLayoutPanelPedidos
            // 
            this.tableLayoutPanelPedidos.ColumnCount = 1;
            this.tableLayoutPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPedidos.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanelPedidos.Name = "tableLayoutPanelPedidos";
            this.tableLayoutPanelPedidos.RowCount = 1;
            this.tableLayoutPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPedidos.Size = new System.Drawing.Size(964, 396);
            this.tableLayoutPanelPedidos.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpPedidos;
        private TableLayoutPanel tlpCamarero_mesa;
        private Label labelNumero_mesa;
        private NumericUpDown numericUpDownNumero_mesa;
        private Button btnAgregarPedido;
        private TableLayoutPanel tableLayoutPanelPedidos;
    }
}
