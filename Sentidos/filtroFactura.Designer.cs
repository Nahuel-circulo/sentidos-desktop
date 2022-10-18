namespace Sentidos
{
    partial class filtroFactura
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
            this.tableLayoutPanelListados = new System.Windows.Forms.TableLayoutPanel();
            this.labelPedidos = new System.Windows.Forms.Label();
            this.dataGridViewPedidosDefault = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanellistadosTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.btnListadoMesasReservadas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerarFactura = new System.Windows.Forms.Button();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosDefault)).BeginInit();
            this.tableLayoutPanellistadosTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelListados
            // 
            this.tableLayoutPanelListados.ColumnCount = 3;
            this.tableLayoutPanelListados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.92574F));
            this.tableLayoutPanelListados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.07426F));
            this.tableLayoutPanelListados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanelListados.Controls.Add(this.labelPedidos, 1, 0);
            this.tableLayoutPanelListados.Controls.Add(this.dataGridViewPedidosDefault, 1, 1);
            this.tableLayoutPanelListados.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanelListados.Name = "tableLayoutPanelListados";
            this.tableLayoutPanelListados.RowCount = 2;
            this.tableLayoutPanelListados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanelListados.Size = new System.Drawing.Size(964, 402);
            this.tableLayoutPanelListados.TabIndex = 3;
            // 
            // labelPedidos
            // 
            this.labelPedidos.AutoSize = true;
            this.labelPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPedidos.Location = new System.Drawing.Point(162, 0);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(635, 34);
            this.labelPedidos.TabIndex = 0;
            this.labelPedidos.Text = "labelListadosPorDefault";
            this.labelPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPedidosDefault
            // 
            this.dataGridViewPedidosDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidosDefault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnMesa});
            this.dataGridViewPedidosDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidosDefault.Location = new System.Drawing.Point(162, 37);
            this.dataGridViewPedidosDefault.Name = "dataGridViewPedidosDefault";
            this.dataGridViewPedidosDefault.RowTemplate.Height = 25;
            this.dataGridViewPedidosDefault.Size = new System.Drawing.Size(635, 362);
            this.dataGridViewPedidosDefault.TabIndex = 1;
            // 
            // tableLayoutPanellistadosTop
            // 
            this.tableLayoutPanellistadosTop.ColumnCount = 4;
            this.tableLayoutPanellistadosTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.96715F));
            this.tableLayoutPanellistadosTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03286F));
            this.tableLayoutPanellistadosTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanellistadosTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanellistadosTop.Controls.Add(this.btnListadoClientes, 1, 0);
            this.tableLayoutPanellistadosTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanellistadosTop.Name = "tableLayoutPanellistadosTop";
            this.tableLayoutPanellistadosTop.RowCount = 2;
            this.tableLayoutPanellistadosTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanellistadosTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanellistadosTop.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanellistadosTop.TabIndex = 0;
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListadoClientes.Location = new System.Drawing.Point(-184, 3);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Size = new System.Drawing.Size(1, 14);
            this.btnListadoClientes.TabIndex = 0;
            this.btnListadoClientes.Text = "Clientes";
            this.btnListadoClientes.UseVisualStyleBackColor = true;
            // 
            // btnListadoMesasReservadas
            // 
            this.btnListadoMesasReservadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListadoMesasReservadas.Location = new System.Drawing.Point(-272, 3);
            this.btnListadoMesasReservadas.Name = "btnListadoMesasReservadas";
            this.btnListadoMesasReservadas.Size = new System.Drawing.Size(157, 56);
            this.btnListadoMesasReservadas.TabIndex = 1;
            this.btnListadoMesasReservadas.Text = "Mesas Reservadas";
            this.btnListadoMesasReservadas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.96715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerarFactura, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.9315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.06849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 63);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonGenerarFactura
            // 
            this.buttonGenerarFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerarFactura.Location = new System.Drawing.Point(613, 3);
            this.buttonGenerarFactura.Name = "buttonGenerarFactura";
            this.buttonGenerarFactura.Size = new System.Drawing.Size(182, 47);
            this.buttonGenerarFactura.TabIndex = 1;
            this.buttonGenerarFactura.Text = "Generar factura";
            this.buttonGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnMesa
            // 
            this.ColumnMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMesa.HeaderText = "Mesa";
            this.ColumnMesa.Name = "ColumnMesa";
            // 
            // filtroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelListados);
            this.Name = "filtroFactura";
            this.Size = new System.Drawing.Size(968, 533);
            this.tableLayoutPanelListados.ResumeLayout(false);
            this.tableLayoutPanelListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosDefault)).EndInit();
            this.tableLayoutPanellistadosTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelListados;
        private Label labelPedidos;
        private DataGridView dataGridViewPedidosDefault;
        private TableLayoutPanel tableLayoutPanellistadosTop;
        private Button btnListadoClientes;
        private Button btnListadoMesasReservadas;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonGenerarFactura;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnMesa;
    }
}
