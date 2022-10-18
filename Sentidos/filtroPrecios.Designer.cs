namespace Sentidos
{
    partial class filtroPrecios
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
            this.flowLayoutPanelFiltroPrecios = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreciosRestaurante = new System.Windows.Forms.Button();
            this.btnPreciosCasa_Té = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelListaPrecios = new System.Windows.Forms.Label();
            this.dataGridViewPrecios = new System.Windows.Forms.DataGridView();
            this.Column1PlatoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2DescripcionPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelFiltroPrecios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelFiltroPrecios
            // 
            this.flowLayoutPanelFiltroPrecios.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelFiltroPrecios.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanelFiltroPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFiltroPrecios.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFiltroPrecios.Name = "flowLayoutPanelFiltroPrecios";
            this.flowLayoutPanelFiltroPrecios.Size = new System.Drawing.Size(967, 531);
            this.flowLayoutPanelFiltroPrecios.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.96715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel1.Controls.Add(this.btnPreciosRestaurante, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPreciosCasa_Té, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.9315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.06849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPreciosRestaurante
            // 
            this.btnPreciosRestaurante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreciosRestaurante.Location = new System.Drawing.Point(334, 3);
            this.btnPreciosRestaurante.Name = "btnPreciosRestaurante";
            this.btnPreciosRestaurante.Size = new System.Drawing.Size(150, 56);
            this.btnPreciosRestaurante.TabIndex = 0;
            this.btnPreciosRestaurante.Text = " Restaurante";
            this.btnPreciosRestaurante.UseVisualStyleBackColor = true;
            this.btnPreciosRestaurante.Click += new System.EventHandler(this.btnPreciosRestaurante_Click);
            // 
            // btnPreciosCasa_Té
            // 
            this.btnPreciosCasa_Té.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreciosCasa_Té.Location = new System.Drawing.Point(490, 3);
            this.btnPreciosCasa_Té.Name = "btnPreciosCasa_Té";
            this.btnPreciosCasa_Té.Size = new System.Drawing.Size(157, 56);
            this.btnPreciosCasa_Té.TabIndex = 1;
            this.btnPreciosCasa_Té.Text = "Casa de Té";
            this.btnPreciosCasa_Té.UseVisualStyleBackColor = true;
            this.btnPreciosCasa_Té.Click += new System.EventHandler(this.btnPreciosCasa_Té_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.92574F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.07426F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.Controls.Add(this.labelListaPrecios, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewPrecios, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 402);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelListaPrecios
            // 
            this.labelListaPrecios.AutoSize = true;
            this.labelListaPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelListaPrecios.Location = new System.Drawing.Point(162, 0);
            this.labelListaPrecios.Name = "labelListaPrecios";
            this.labelListaPrecios.Size = new System.Drawing.Size(635, 34);
            this.labelListaPrecios.TabIndex = 0;
            this.labelListaPrecios.Text = "labelPreciosPorDefault";
            this.labelListaPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPrecios
            // 
            this.dataGridViewPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1PlatoNombre,
            this.Column2DescripcionPlato,
            this.ColumnPrecio});
            this.dataGridViewPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrecios.Location = new System.Drawing.Point(162, 37);
            this.dataGridViewPrecios.Name = "dataGridViewPrecios";
            this.dataGridViewPrecios.RowTemplate.Height = 25;
            this.dataGridViewPrecios.Size = new System.Drawing.Size(635, 362);
            this.dataGridViewPrecios.TabIndex = 1;
            // 
            // Column1PlatoNombre
            // 
            this.Column1PlatoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1PlatoNombre.HeaderText = "Nombre";
            this.Column1PlatoNombre.Name = "Column1PlatoNombre";
            // 
            // Column2DescripcionPlato
            // 
            this.Column2DescripcionPlato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2DescripcionPlato.HeaderText = "Descripción";
            this.Column2DescripcionPlato.Name = "Column2DescripcionPlato";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // filtroPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelFiltroPrecios);
            this.Name = "filtroPrecios";
            this.Size = new System.Drawing.Size(967, 531);
            this.flowLayoutPanelFiltroPrecios.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFiltroPrecios;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPreciosRestaurante;
        private Button btnPreciosCasa_Té;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelListaPrecios;
        private DataGridView dataGridViewPrecios;
        private DataGridViewTextBoxColumn Column1PlatoNombre;
        private DataGridViewTextBoxColumn Column2DescripcionPlato;
        private DataGridViewTextBoxColumn ColumnPrecio;
    }
}
