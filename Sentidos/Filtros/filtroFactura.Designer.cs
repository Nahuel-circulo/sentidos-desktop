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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelListados = new System.Windows.Forms.TableLayoutPanel();
            this.labelFacturas = new System.Windows.Forms.Label();
            this.dataGridViewPedidosDefault = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanellistadosTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.btnListadoMesasReservadas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerarFactura = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelListados.Controls.Add(this.labelFacturas, 1, 0);
            this.tableLayoutPanelListados.Controls.Add(this.dataGridViewPedidosDefault, 1, 1);
            this.tableLayoutPanelListados.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanelListados.Name = "tableLayoutPanelListados";
            this.tableLayoutPanelListados.RowCount = 2;
            this.tableLayoutPanelListados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanelListados.Size = new System.Drawing.Size(964, 402);
            this.tableLayoutPanelListados.TabIndex = 3;
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFacturas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFacturas.Location = new System.Drawing.Point(162, 0);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(635, 34);
            this.labelFacturas.TabIndex = 0;
            this.labelFacturas.Text = "Pedidos Realizados:";
            this.labelFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPedidosDefault
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPedidosDefault.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedidosDefault.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPedidosDefault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidosDefault.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPedidosDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidosDefault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnMesa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidosDefault.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPedidosDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidosDefault.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.dataGridViewPedidosDefault.Location = new System.Drawing.Point(162, 37);
            this.dataGridViewPedidosDefault.Name = "dataGridViewPedidosDefault";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidosDefault.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPedidosDefault.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPedidosDefault.RowTemplate.Height = 25;
            this.dataGridViewPedidosDefault.Size = new System.Drawing.Size(635, 362);
            this.dataGridViewPedidosDefault.TabIndex = 1;
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
            this.buttonGenerarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.buttonGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerarFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.buttonGenerarFactura.FlatAppearance.BorderSize = 0;
            this.buttonGenerarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarFactura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerarFactura.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarFactura.Location = new System.Drawing.Point(613, 3);
            this.buttonGenerarFactura.Name = "buttonGenerarFactura";
            this.buttonGenerarFactura.Size = new System.Drawing.Size(182, 47);
            this.buttonGenerarFactura.TabIndex = 1;
            this.buttonGenerarFactura.Text = "Generar factura";
            this.buttonGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // filtroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
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
        private Label labelFacturas;
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
