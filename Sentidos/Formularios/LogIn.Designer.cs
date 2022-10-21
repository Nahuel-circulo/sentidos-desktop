namespace Sentidos
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelLogIn = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.textBoxNombre_Usuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelLogIn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelLogIn);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(454, 314);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanelLogIn
            // 
            this.tableLayoutPanelLogIn.ColumnCount = 4;
            this.tableLayoutPanelLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.26191F));
            this.tableLayoutPanelLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7381F));
            this.tableLayoutPanelLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanelLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelLogIn.Controls.Add(this.labelNombreUsuario, 1, 1);
            this.tableLayoutPanelLogIn.Controls.Add(this.labelContraseña, 1, 2);
            this.tableLayoutPanelLogIn.Controls.Add(this.labelRol, 1, 3);
            this.tableLayoutPanelLogIn.Controls.Add(this.textBoxNombre_Usuario, 2, 1);
            this.tableLayoutPanelLogIn.Controls.Add(this.textBoxContraseña, 2, 2);
            this.tableLayoutPanelLogIn.Controls.Add(this.comboBoxRol, 2, 3);
            this.tableLayoutPanelLogIn.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanelLogIn.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLogIn.Name = "tableLayoutPanelLogIn";
            this.tableLayoutPanelLogIn.RowCount = 5;
            this.tableLayoutPanelLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tableLayoutPanelLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tableLayoutPanelLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelLogIn.Size = new System.Drawing.Size(451, 198);
            this.tableLayoutPanelLogIn.TabIndex = 1;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombreUsuario.Location = new System.Drawing.Point(29, 48);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(119, 47);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre de usuario:";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContraseña.Location = new System.Drawing.Point(29, 95);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(119, 39);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRol.Location = new System.Drawing.Point(29, 134);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(119, 41);
            this.labelRol.TabIndex = 2;
            this.labelRol.Text = "Rol:";
            this.labelRol.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxNombre_Usuario
            // 
            this.textBoxNombre_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre_Usuario.Location = new System.Drawing.Point(154, 69);
            this.textBoxNombre_Usuario.Name = "textBoxNombre_Usuario";
            this.textBoxNombre_Usuario.Size = new System.Drawing.Size(236, 23);
            this.textBoxNombre_Usuario.TabIndex = 3;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContraseña.Location = new System.Drawing.Point(154, 108);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(236, 23);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "P",
            "Mz",
            "C",
            "Ma"});
            this.comboBoxRol.Location = new System.Drawing.Point(154, 149);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(236, 23);
            this.comboBoxRol.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.83042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.16957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAceptar, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.Location = new System.Drawing.Point(270, 36);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(121, 29);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 314);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LogIn";
            this.Text = "Sentidos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelLogIn.ResumeLayout(false);
            this.tableLayoutPanelLogIn.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelLogIn;
        private Label labelNombreUsuario;
        private Label labelContraseña;
        private Label labelRol;
        private TextBox textBoxNombre_Usuario;
        private TextBox textBoxContraseña;
        private ComboBox comboBoxRol;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAceptar;
        private PictureBox pictureBox1;
    }
}