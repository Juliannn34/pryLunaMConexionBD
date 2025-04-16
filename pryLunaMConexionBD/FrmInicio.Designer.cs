namespace pryLunaMConexionBD
{
    partial class FrmInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRecargarGillaAgregar = new System.Windows.Forms.Button();
            this.cmbCategoriasContactoAgregar = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregarContacto = new MaterialSkin.Controls.MaterialButton();
            this.txtCorreoContactoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefonoContactoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidoContactoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvContactosAgregar = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreContactoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRecargarGrillaModificar = new System.Windows.Forms.Button();
            this.btnModificarCategoriaContacto = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarTelefonoContacto = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarCorreoContacto = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarApellidoContacto = new MaterialSkin.Controls.MaterialButton();
            this.txtIdContactoModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvModificarContactos = new System.Windows.Forms.DataGridView();
            this.txtNombreContactoModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidoContactoModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefonoContactoModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreoContactoModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnModificarContacto = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoriaContactoModificar = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRecargarEliminar = new System.Windows.Forms.Button();
            this.txtEliminarIdContacto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarIdContacto = new MaterialSkin.Controls.MaterialButton();
            this.dgvEliminarContacto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreProductoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionProductoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvProductoAgregar = new System.Windows.Forms.DataGridView();
            this.txtStockProductoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioProductoAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCategoriasProductoAgregar = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscarIDContactos = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosAgregar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarContactos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarContacto)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1040, 516);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRecargarGillaAgregar);
            this.tabPage1.Controls.Add(this.cmbCategoriasContactoAgregar);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.btnAgregarContacto);
            this.tabPage1.Controls.Add(this.txtCorreoContactoAgregar);
            this.tabPage1.Controls.Add(this.txtTelefonoContactoAgregar);
            this.tabPage1.Controls.Add(this.txtApellidoContactoAgregar);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.dgvContactosAgregar);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.txtNombreContactoAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Contactos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRecargarGillaAgregar
            // 
            this.btnRecargarGillaAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarGillaAgregar.BackgroundImage = global::pryLunaMConexionBD.Properties.Resources._14025098;
            this.btnRecargarGillaAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarGillaAgregar.CausesValidation = false;
            this.btnRecargarGillaAgregar.FlatAppearance.BorderSize = 0;
            this.btnRecargarGillaAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarGillaAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarGillaAgregar.Location = new System.Drawing.Point(970, 441);
            this.btnRecargarGillaAgregar.Name = "btnRecargarGillaAgregar";
            this.btnRecargarGillaAgregar.Size = new System.Drawing.Size(42, 43);
            this.btnRecargarGillaAgregar.TabIndex = 12;
            this.btnRecargarGillaAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargarGillaAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRecargarGillaAgregar.UseVisualStyleBackColor = false;
            this.btnRecargarGillaAgregar.Click += new System.EventHandler(this.btnRecargarGillaAgregar_Click);
            // 
            // cmbCategoriasContactoAgregar
            // 
            this.cmbCategoriasContactoAgregar.AutoResize = false;
            this.cmbCategoriasContactoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriasContactoAgregar.Depth = 0;
            this.cmbCategoriasContactoAgregar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriasContactoAgregar.DropDownHeight = 174;
            this.cmbCategoriasContactoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriasContactoAgregar.DropDownWidth = 121;
            this.cmbCategoriasContactoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriasContactoAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriasContactoAgregar.FormattingEnabled = true;
            this.cmbCategoriasContactoAgregar.IntegralHeight = false;
            this.cmbCategoriasContactoAgregar.ItemHeight = 43;
            this.cmbCategoriasContactoAgregar.Location = new System.Drawing.Point(119, 314);
            this.cmbCategoriasContactoAgregar.MaxDropDownItems = 4;
            this.cmbCategoriasContactoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriasContactoAgregar.Name = "cmbCategoriasContactoAgregar";
            this.cmbCategoriasContactoAgregar.Size = new System.Drawing.Size(252, 49);
            this.cmbCategoriasContactoAgregar.StartIndex = 0;
            this.cmbCategoriasContactoAgregar.TabIndex = 5;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(32, 332);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Correo:";
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarContacto.Depth = 0;
            this.btnAgregarContacto.HighEmphasis = true;
            this.btnAgregarContacto.Icon = null;
            this.btnAgregarContacto.Location = new System.Drawing.Point(144, 401);
            this.btnAgregarContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarContacto.Size = new System.Drawing.Size(169, 36);
            this.btnAgregarContacto.TabIndex = 6;
            this.btnAgregarContacto.Text = "Agregar Contacto";
            this.btnAgregarContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarContacto.UseAccentColor = false;
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // txtCorreoContactoAgregar
            // 
            this.txtCorreoContactoAgregar.AnimateReadOnly = false;
            this.txtCorreoContactoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoContactoAgregar.Depth = 0;
            this.txtCorreoContactoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreoContactoAgregar.LeadingIcon = null;
            this.txtCorreoContactoAgregar.Location = new System.Drawing.Point(119, 235);
            this.txtCorreoContactoAgregar.MaxLength = 50;
            this.txtCorreoContactoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreoContactoAgregar.Multiline = false;
            this.txtCorreoContactoAgregar.Name = "txtCorreoContactoAgregar";
            this.txtCorreoContactoAgregar.Size = new System.Drawing.Size(252, 50);
            this.txtCorreoContactoAgregar.TabIndex = 4;
            this.txtCorreoContactoAgregar.Text = "";
            this.txtCorreoContactoAgregar.TrailingIcon = null;
            // 
            // txtTelefonoContactoAgregar
            // 
            this.txtTelefonoContactoAgregar.AnimateReadOnly = false;
            this.txtTelefonoContactoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoContactoAgregar.Depth = 0;
            this.txtTelefonoContactoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoContactoAgregar.LeadingIcon = null;
            this.txtTelefonoContactoAgregar.Location = new System.Drawing.Point(119, 167);
            this.txtTelefonoContactoAgregar.MaxLength = 50;
            this.txtTelefonoContactoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoContactoAgregar.Multiline = false;
            this.txtTelefonoContactoAgregar.Name = "txtTelefonoContactoAgregar";
            this.txtTelefonoContactoAgregar.Size = new System.Drawing.Size(252, 50);
            this.txtTelefonoContactoAgregar.TabIndex = 3;
            this.txtTelefonoContactoAgregar.Text = "";
            this.txtTelefonoContactoAgregar.TrailingIcon = null;
            // 
            // txtApellidoContactoAgregar
            // 
            this.txtApellidoContactoAgregar.AnimateReadOnly = false;
            this.txtApellidoContactoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoContactoAgregar.Depth = 0;
            this.txtApellidoContactoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoContactoAgregar.LeadingIcon = null;
            this.txtApellidoContactoAgregar.Location = new System.Drawing.Point(119, 98);
            this.txtApellidoContactoAgregar.MaxLength = 50;
            this.txtApellidoContactoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoContactoAgregar.Multiline = false;
            this.txtApellidoContactoAgregar.Name = "txtApellidoContactoAgregar";
            this.txtApellidoContactoAgregar.Size = new System.Drawing.Size(252, 50);
            this.txtApellidoContactoAgregar.TabIndex = 2;
            this.txtApellidoContactoAgregar.Text = "";
            this.txtApellidoContactoAgregar.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(32, 252);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Correo:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(32, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Telefono:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(32, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Apellido:";
            // 
            // dgvContactosAgregar
            // 
            this.dgvContactosAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosAgregar.Location = new System.Drawing.Point(392, 15);
            this.dgvContactosAgregar.Name = "dgvContactosAgregar";
            this.dgvContactosAgregar.Size = new System.Drawing.Size(620, 393);
            this.dgvContactosAgregar.TabIndex = 7;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(32, 39);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nombre:";
            // 
            // txtNombreContactoAgregar
            // 
            this.txtNombreContactoAgregar.AnimateReadOnly = false;
            this.txtNombreContactoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreContactoAgregar.Depth = 0;
            this.txtNombreContactoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreContactoAgregar.LeadingIcon = null;
            this.txtNombreContactoAgregar.Location = new System.Drawing.Point(119, 25);
            this.txtNombreContactoAgregar.MaxLength = 50;
            this.txtNombreContactoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreContactoAgregar.Multiline = false;
            this.txtNombreContactoAgregar.Name = "txtNombreContactoAgregar";
            this.txtNombreContactoAgregar.Size = new System.Drawing.Size(252, 50);
            this.txtNombreContactoAgregar.TabIndex = 1;
            this.txtNombreContactoAgregar.Text = "";
            this.txtNombreContactoAgregar.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarIDContactos);
            this.tabPage2.Controls.Add(this.btnRecargarGrillaModificar);
            this.tabPage2.Controls.Add(this.btnModificarCategoriaContacto);
            this.tabPage2.Controls.Add(this.btnModificarTelefonoContacto);
            this.tabPage2.Controls.Add(this.btnModificarCorreoContacto);
            this.tabPage2.Controls.Add(this.btnModificarApellidoContacto);
            this.tabPage2.Controls.Add(this.txtIdContactoModificar);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.dgvModificarContactos);
            this.tabPage2.Controls.Add(this.txtNombreContactoModificar);
            this.tabPage2.Controls.Add(this.txtApellidoContactoModificar);
            this.tabPage2.Controls.Add(this.txtTelefonoContactoModificar);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.txtCorreoContactoModificar);
            this.tabPage2.Controls.Add(this.btnModificarContacto);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.cmbCategoriaContactoModificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Contactos";
            // 
            // btnRecargarGrillaModificar
            // 
            this.btnRecargarGrillaModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarGrillaModificar.BackgroundImage = global::pryLunaMConexionBD.Properties.Resources._14025098;
            this.btnRecargarGrillaModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarGrillaModificar.CausesValidation = false;
            this.btnRecargarGrillaModificar.FlatAppearance.BorderSize = 0;
            this.btnRecargarGrillaModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarGrillaModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarGrillaModificar.Location = new System.Drawing.Point(987, 444);
            this.btnRecargarGrillaModificar.Name = "btnRecargarGrillaModificar";
            this.btnRecargarGrillaModificar.Size = new System.Drawing.Size(42, 43);
            this.btnRecargarGrillaModificar.TabIndex = 19;
            this.btnRecargarGrillaModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargarGrillaModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRecargarGrillaModificar.UseVisualStyleBackColor = false;
            this.btnRecargarGrillaModificar.Click += new System.EventHandler(this.btnRecargarGrillaModificar_Click);
            // 
            // btnModificarCategoriaContacto
            // 
            this.btnModificarCategoriaContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarCategoriaContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarCategoriaContacto.Depth = 0;
            this.btnModificarCategoriaContacto.HighEmphasis = true;
            this.btnModificarCategoriaContacto.Icon = null;
            this.btnModificarCategoriaContacto.Location = new System.Drawing.Point(782, 428);
            this.btnModificarCategoriaContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarCategoriaContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarCategoriaContacto.Name = "btnModificarCategoriaContacto";
            this.btnModificarCategoriaContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarCategoriaContacto.Size = new System.Drawing.Size(183, 36);
            this.btnModificarCategoriaContacto.TabIndex = 18;
            this.btnModificarCategoriaContacto.Text = "Modificar Categoria";
            this.btnModificarCategoriaContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarCategoriaContacto.UseAccentColor = false;
            this.btnModificarCategoriaContacto.UseVisualStyleBackColor = true;
            this.btnModificarCategoriaContacto.Click += new System.EventHandler(this.btnModificarCategoriaContacto_Click);
            // 
            // btnModificarTelefonoContacto
            // 
            this.btnModificarTelefonoContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarTelefonoContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarTelefonoContacto.Depth = 0;
            this.btnModificarTelefonoContacto.HighEmphasis = true;
            this.btnModificarTelefonoContacto.Icon = null;
            this.btnModificarTelefonoContacto.Location = new System.Drawing.Point(404, 428);
            this.btnModificarTelefonoContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarTelefonoContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarTelefonoContacto.Name = "btnModificarTelefonoContacto";
            this.btnModificarTelefonoContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarTelefonoContacto.Size = new System.Drawing.Size(176, 36);
            this.btnModificarTelefonoContacto.TabIndex = 17;
            this.btnModificarTelefonoContacto.Text = "Modificar Telefono";
            this.btnModificarTelefonoContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarTelefonoContacto.UseAccentColor = false;
            this.btnModificarTelefonoContacto.UseVisualStyleBackColor = true;
            this.btnModificarTelefonoContacto.Click += new System.EventHandler(this.btnModificarTelefonoContacto_Click);
            // 
            // btnModificarCorreoContacto
            // 
            this.btnModificarCorreoContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarCorreoContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarCorreoContacto.Depth = 0;
            this.btnModificarCorreoContacto.HighEmphasis = true;
            this.btnModificarCorreoContacto.Icon = null;
            this.btnModificarCorreoContacto.Location = new System.Drawing.Point(593, 428);
            this.btnModificarCorreoContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarCorreoContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarCorreoContacto.Name = "btnModificarCorreoContacto";
            this.btnModificarCorreoContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarCorreoContacto.Size = new System.Drawing.Size(160, 36);
            this.btnModificarCorreoContacto.TabIndex = 16;
            this.btnModificarCorreoContacto.Text = "Modificar Correo";
            this.btnModificarCorreoContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarCorreoContacto.UseAccentColor = false;
            this.btnModificarCorreoContacto.UseVisualStyleBackColor = true;
            this.btnModificarCorreoContacto.Click += new System.EventHandler(this.btnModificarCorreoContacto_Click);
            // 
            // btnModificarApellidoContacto
            // 
            this.btnModificarApellidoContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarApellidoContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarApellidoContacto.Depth = 0;
            this.btnModificarApellidoContacto.HighEmphasis = true;
            this.btnModificarApellidoContacto.Icon = null;
            this.btnModificarApellidoContacto.Location = new System.Drawing.Point(214, 428);
            this.btnModificarApellidoContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarApellidoContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarApellidoContacto.Name = "btnModificarApellidoContacto";
            this.btnModificarApellidoContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarApellidoContacto.Size = new System.Drawing.Size(171, 36);
            this.btnModificarApellidoContacto.TabIndex = 15;
            this.btnModificarApellidoContacto.Text = "Modificar Apellido";
            this.btnModificarApellidoContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarApellidoContacto.UseAccentColor = false;
            this.btnModificarApellidoContacto.UseVisualStyleBackColor = true;
            this.btnModificarApellidoContacto.Click += new System.EventHandler(this.btnModificarApellidoContacto_Click);
            // 
            // txtIdContactoModificar
            // 
            this.txtIdContactoModificar.AnimateReadOnly = false;
            this.txtIdContactoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdContactoModificar.Depth = 0;
            this.txtIdContactoModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdContactoModificar.LeadingIcon = null;
            this.txtIdContactoModificar.Location = new System.Drawing.Point(148, 16);
            this.txtIdContactoModificar.MaxLength = 50;
            this.txtIdContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdContactoModificar.Multiline = false;
            this.txtIdContactoModificar.Name = "txtIdContactoModificar";
            this.txtIdContactoModificar.Size = new System.Drawing.Size(75, 50);
            this.txtIdContactoModificar.TabIndex = 13;
            this.txtIdContactoModificar.Text = "";
            this.txtIdContactoModificar.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(23, 29);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(106, 19);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "Seleccionar ID:";
            // 
            // dgvModificarContactos
            // 
            this.dgvModificarContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarContactos.Location = new System.Drawing.Point(367, 16);
            this.dgvModificarContactos.Name = "dgvModificarContactos";
            this.dgvModificarContactos.Size = new System.Drawing.Size(645, 380);
            this.dgvModificarContactos.TabIndex = 11;
            // 
            // txtNombreContactoModificar
            // 
            this.txtNombreContactoModificar.AnimateReadOnly = false;
            this.txtNombreContactoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreContactoModificar.Depth = 0;
            this.txtNombreContactoModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreContactoModificar.LeadingIcon = null;
            this.txtNombreContactoModificar.Location = new System.Drawing.Point(110, 79);
            this.txtNombreContactoModificar.MaxLength = 50;
            this.txtNombreContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreContactoModificar.Multiline = false;
            this.txtNombreContactoModificar.Name = "txtNombreContactoModificar";
            this.txtNombreContactoModificar.Size = new System.Drawing.Size(237, 50);
            this.txtNombreContactoModificar.TabIndex = 10;
            this.txtNombreContactoModificar.Text = "";
            this.txtNombreContactoModificar.TrailingIcon = null;
            // 
            // txtApellidoContactoModificar
            // 
            this.txtApellidoContactoModificar.AnimateReadOnly = false;
            this.txtApellidoContactoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoContactoModificar.Depth = 0;
            this.txtApellidoContactoModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoContactoModificar.LeadingIcon = null;
            this.txtApellidoContactoModificar.Location = new System.Drawing.Point(110, 148);
            this.txtApellidoContactoModificar.MaxLength = 50;
            this.txtApellidoContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoContactoModificar.Multiline = false;
            this.txtApellidoContactoModificar.Name = "txtApellidoContactoModificar";
            this.txtApellidoContactoModificar.Size = new System.Drawing.Size(237, 50);
            this.txtApellidoContactoModificar.TabIndex = 9;
            this.txtApellidoContactoModificar.Text = "";
            this.txtApellidoContactoModificar.TrailingIcon = null;
            // 
            // txtTelefonoContactoModificar
            // 
            this.txtTelefonoContactoModificar.AnimateReadOnly = false;
            this.txtTelefonoContactoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoContactoModificar.Depth = 0;
            this.txtTelefonoContactoModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoContactoModificar.LeadingIcon = null;
            this.txtTelefonoContactoModificar.Location = new System.Drawing.Point(110, 218);
            this.txtTelefonoContactoModificar.MaxLength = 50;
            this.txtTelefonoContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoContactoModificar.Multiline = false;
            this.txtTelefonoContactoModificar.Name = "txtTelefonoContactoModificar";
            this.txtTelefonoContactoModificar.Size = new System.Drawing.Size(237, 50);
            this.txtTelefonoContactoModificar.TabIndex = 8;
            this.txtTelefonoContactoModificar.Text = "";
            this.txtTelefonoContactoModificar.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(23, 375);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(73, 19);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "Categoria:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(23, 304);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(51, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Correo:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(23, 232);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(68, 19);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "Telefono:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(23, 166);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(62, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Apellido:";
            // 
            // txtCorreoContactoModificar
            // 
            this.txtCorreoContactoModificar.AnimateReadOnly = false;
            this.txtCorreoContactoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoContactoModificar.Depth = 0;
            this.txtCorreoContactoModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreoContactoModificar.LeadingIcon = null;
            this.txtCorreoContactoModificar.Location = new System.Drawing.Point(110, 289);
            this.txtCorreoContactoModificar.MaxLength = 50;
            this.txtCorreoContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreoContactoModificar.Multiline = false;
            this.txtCorreoContactoModificar.Name = "txtCorreoContactoModificar";
            this.txtCorreoContactoModificar.Size = new System.Drawing.Size(237, 50);
            this.txtCorreoContactoModificar.TabIndex = 3;
            this.txtCorreoContactoModificar.Text = "";
            this.txtCorreoContactoModificar.TrailingIcon = null;
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarContacto.Depth = 0;
            this.btnModificarContacto.HighEmphasis = true;
            this.btnModificarContacto.Icon = null;
            this.btnModificarContacto.Location = new System.Drawing.Point(26, 428);
            this.btnModificarContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarContacto.Size = new System.Drawing.Size(163, 36);
            this.btnModificarContacto.TabIndex = 2;
            this.btnModificarContacto.Text = "Modificar Nombre";
            this.btnModificarContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarContacto.UseAccentColor = false;
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(23, 97);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Nombre:";
            // 
            // cmbCategoriaContactoModificar
            // 
            this.cmbCategoriaContactoModificar.AutoResize = false;
            this.cmbCategoriaContactoModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriaContactoModificar.Depth = 0;
            this.cmbCategoriaContactoModificar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriaContactoModificar.DropDownHeight = 174;
            this.cmbCategoriaContactoModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaContactoModificar.DropDownWidth = 121;
            this.cmbCategoriaContactoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriaContactoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriaContactoModificar.FormattingEnabled = true;
            this.cmbCategoriaContactoModificar.IntegralHeight = false;
            this.cmbCategoriaContactoModificar.ItemHeight = 43;
            this.cmbCategoriaContactoModificar.Location = new System.Drawing.Point(110, 358);
            this.cmbCategoriaContactoModificar.MaxDropDownItems = 4;
            this.cmbCategoriaContactoModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriaContactoModificar.Name = "cmbCategoriaContactoModificar";
            this.cmbCategoriaContactoModificar.Size = new System.Drawing.Size(237, 49);
            this.cmbCategoriaContactoModificar.StartIndex = 0;
            this.cmbCategoriaContactoModificar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRecargarEliminar);
            this.tabPage3.Controls.Add(this.txtEliminarIdContacto);
            this.tabPage3.Controls.Add(this.materialLabel12);
            this.tabPage3.Controls.Add(this.btnEliminarIdContacto);
            this.tabPage3.Controls.Add(this.dgvEliminarContacto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1032, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Contactos";
            // 
            // btnRecargarEliminar
            // 
            this.btnRecargarEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarEliminar.BackgroundImage = global::pryLunaMConexionBD.Properties.Resources._14025098;
            this.btnRecargarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarEliminar.CausesValidation = false;
            this.btnRecargarEliminar.FlatAppearance.BorderSize = 0;
            this.btnRecargarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarEliminar.Location = new System.Drawing.Point(984, 444);
            this.btnRecargarEliminar.Name = "btnRecargarEliminar";
            this.btnRecargarEliminar.Size = new System.Drawing.Size(42, 43);
            this.btnRecargarEliminar.TabIndex = 4;
            this.btnRecargarEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargarEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRecargarEliminar.UseVisualStyleBackColor = false;
            this.btnRecargarEliminar.Click += new System.EventHandler(this.btnRecargarEliminar_Click);
            // 
            // txtEliminarIdContacto
            // 
            this.txtEliminarIdContacto.AnimateReadOnly = false;
            this.txtEliminarIdContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliminarIdContacto.Depth = 0;
            this.txtEliminarIdContacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEliminarIdContacto.LeadingIcon = null;
            this.txtEliminarIdContacto.Location = new System.Drawing.Point(176, 50);
            this.txtEliminarIdContacto.MaxLength = 50;
            this.txtEliminarIdContacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEliminarIdContacto.Multiline = false;
            this.txtEliminarIdContacto.Name = "txtEliminarIdContacto";
            this.txtEliminarIdContacto.Size = new System.Drawing.Size(98, 50);
            this.txtEliminarIdContacto.TabIndex = 3;
            this.txtEliminarIdContacto.Text = "";
            this.txtEliminarIdContacto.TrailingIcon = null;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(30, 66);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(109, 19);
            this.materialLabel12.TabIndex = 2;
            this.materialLabel12.Text = "Eliminar por ID:";
            // 
            // btnEliminarIdContacto
            // 
            this.btnEliminarIdContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarIdContacto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarIdContacto.Depth = 0;
            this.btnEliminarIdContacto.HighEmphasis = true;
            this.btnEliminarIdContacto.Icon = null;
            this.btnEliminarIdContacto.Location = new System.Drawing.Point(85, 134);
            this.btnEliminarIdContacto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarIdContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarIdContacto.Name = "btnEliminarIdContacto";
            this.btnEliminarIdContacto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarIdContacto.Size = new System.Drawing.Size(138, 36);
            this.btnEliminarIdContacto.TabIndex = 1;
            this.btnEliminarIdContacto.Text = "Eliminar por ID";
            this.btnEliminarIdContacto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarIdContacto.UseAccentColor = false;
            this.btnEliminarIdContacto.UseVisualStyleBackColor = true;
            this.btnEliminarIdContacto.Click += new System.EventHandler(this.btnEliminarIdContacto_Click);
            // 
            // dgvEliminarContacto
            // 
            this.dgvEliminarContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarContacto.Location = new System.Drawing.Point(307, 19);
            this.dgvEliminarContacto.Name = "dgvEliminarContacto";
            this.dgvEliminarContacto.Size = new System.Drawing.Size(707, 308);
            this.dgvEliminarContacto.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1032, 490);
            this.tabPage4.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmbCategoriasProductoAgregar);
            this.tabPage5.Controls.Add(this.dgvProductoAgregar);
            this.tabPage5.Controls.Add(this.txtStockProductoAgregar);
            this.tabPage5.Controls.Add(this.txtDescripcionProductoAgregar);
            this.tabPage5.Controls.Add(this.txtPrecioProductoAgregar);
            this.tabPage5.Controls.Add(this.materialLabel17);
            this.tabPage5.Controls.Add(this.materialLabel16);
            this.tabPage5.Controls.Add(this.materialLabel15);
            this.tabPage5.Controls.Add(this.materialLabel14);
            this.tabPage5.Controls.Add(this.txtNombreProductoAgregar);
            this.tabPage5.Controls.Add(this.materialLabel13);
            this.tabPage5.Controls.Add(this.btnAgregarProducto);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1032, 490);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Agregar Productos ";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1032, 490);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Modificar Productos";
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1032, 490);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Eliminar Productos";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarProducto.Depth = 0;
            this.btnAgregarProducto.HighEmphasis = true;
            this.btnAgregarProducto.Icon = null;
            this.btnAgregarProducto.Location = new System.Drawing.Point(134, 387);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.Size = new System.Drawing.Size(158, 36);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarProducto.UseAccentColor = false;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(29, 31);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(61, 19);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "Nombre:";
            // 
            // txtNombreProductoAgregar
            // 
            this.txtNombreProductoAgregar.AnimateReadOnly = false;
            this.txtNombreProductoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProductoAgregar.Depth = 0;
            this.txtNombreProductoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProductoAgregar.LeadingIcon = null;
            this.txtNombreProductoAgregar.Location = new System.Drawing.Point(170, 17);
            this.txtNombreProductoAgregar.MaxLength = 50;
            this.txtNombreProductoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreProductoAgregar.Multiline = false;
            this.txtNombreProductoAgregar.Name = "txtNombreProductoAgregar";
            this.txtNombreProductoAgregar.Size = new System.Drawing.Size(213, 50);
            this.txtNombreProductoAgregar.TabIndex = 2;
            this.txtNombreProductoAgregar.Text = "";
            this.txtNombreProductoAgregar.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(29, 107);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(88, 19);
            this.materialLabel14.TabIndex = 3;
            this.materialLabel14.Text = "Descripcion:";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(29, 180);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(49, 19);
            this.materialLabel15.TabIndex = 4;
            this.materialLabel15.Text = "Precio:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(29, 254);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(45, 19);
            this.materialLabel16.TabIndex = 5;
            this.materialLabel16.Text = "Stock:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(29, 324);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(73, 19);
            this.materialLabel17.TabIndex = 6;
            this.materialLabel17.Text = "Categoria:";
            this.materialLabel17.Click += new System.EventHandler(this.materialLabel17_Click);
            // 
            // txtDescripcionProductoAgregar
            // 
            this.txtDescripcionProductoAgregar.AnimateReadOnly = false;
            this.txtDescripcionProductoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionProductoAgregar.Depth = 0;
            this.txtDescripcionProductoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionProductoAgregar.LeadingIcon = null;
            this.txtDescripcionProductoAgregar.Location = new System.Drawing.Point(170, 88);
            this.txtDescripcionProductoAgregar.MaxLength = 50;
            this.txtDescripcionProductoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionProductoAgregar.Multiline = false;
            this.txtDescripcionProductoAgregar.Name = "txtDescripcionProductoAgregar";
            this.txtDescripcionProductoAgregar.Size = new System.Drawing.Size(213, 50);
            this.txtDescripcionProductoAgregar.TabIndex = 9;
            this.txtDescripcionProductoAgregar.Text = "";
            this.txtDescripcionProductoAgregar.TrailingIcon = null;
            // 
            // dgvProductoAgregar
            // 
            this.dgvProductoAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoAgregar.Location = new System.Drawing.Point(424, 17);
            this.dgvProductoAgregar.Name = "dgvProductoAgregar";
            this.dgvProductoAgregar.Size = new System.Drawing.Size(602, 340);
            this.dgvProductoAgregar.TabIndex = 11;
            // 
            // txtStockProductoAgregar
            // 
            this.txtStockProductoAgregar.AnimateReadOnly = false;
            this.txtStockProductoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockProductoAgregar.Depth = 0;
            this.txtStockProductoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStockProductoAgregar.LeadingIcon = null;
            this.txtStockProductoAgregar.Location = new System.Drawing.Point(170, 238);
            this.txtStockProductoAgregar.MaxLength = 50;
            this.txtStockProductoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStockProductoAgregar.Multiline = false;
            this.txtStockProductoAgregar.Name = "txtStockProductoAgregar";
            this.txtStockProductoAgregar.Size = new System.Drawing.Size(213, 50);
            this.txtStockProductoAgregar.TabIndex = 10;
            this.txtStockProductoAgregar.Text = "";
            this.txtStockProductoAgregar.TrailingIcon = null;
            // 
            // txtPrecioProductoAgregar
            // 
            this.txtPrecioProductoAgregar.AnimateReadOnly = false;
            this.txtPrecioProductoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioProductoAgregar.Depth = 0;
            this.txtPrecioProductoAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioProductoAgregar.LeadingIcon = null;
            this.txtPrecioProductoAgregar.Location = new System.Drawing.Point(170, 164);
            this.txtPrecioProductoAgregar.MaxLength = 50;
            this.txtPrecioProductoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioProductoAgregar.Multiline = false;
            this.txtPrecioProductoAgregar.Name = "txtPrecioProductoAgregar";
            this.txtPrecioProductoAgregar.Size = new System.Drawing.Size(213, 50);
            this.txtPrecioProductoAgregar.TabIndex = 8;
            this.txtPrecioProductoAgregar.Text = "";
            this.txtPrecioProductoAgregar.TrailingIcon = null;
            // 
            // cmbCategoriasProductoAgregar
            // 
            this.cmbCategoriasProductoAgregar.AutoResize = false;
            this.cmbCategoriasProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriasProductoAgregar.Depth = 0;
            this.cmbCategoriasProductoAgregar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriasProductoAgregar.DropDownHeight = 174;
            this.cmbCategoriasProductoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriasProductoAgregar.DropDownWidth = 121;
            this.cmbCategoriasProductoAgregar.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriasProductoAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriasProductoAgregar.FormattingEnabled = true;
            this.cmbCategoriasProductoAgregar.IntegralHeight = false;
            this.cmbCategoriasProductoAgregar.ItemHeight = 43;
            this.cmbCategoriasProductoAgregar.Location = new System.Drawing.Point(170, 308);
            this.cmbCategoriasProductoAgregar.MaxDropDownItems = 4;
            this.cmbCategoriasProductoAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriasProductoAgregar.Name = "cmbCategoriasProductoAgregar";
            this.cmbCategoriasProductoAgregar.Size = new System.Drawing.Size(213, 49);
            this.cmbCategoriasProductoAgregar.StartIndex = 0;
            this.cmbCategoriasProductoAgregar.TabIndex = 12;
            // 
            // btnBuscarIDContactos
            // 
            this.btnBuscarIDContactos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarIDContactos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarIDContactos.Depth = 0;
            this.btnBuscarIDContactos.HighEmphasis = true;
            this.btnBuscarIDContactos.Icon = null;
            this.btnBuscarIDContactos.Location = new System.Drawing.Point(230, 19);
            this.btnBuscarIDContactos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarIDContactos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarIDContactos.Name = "btnBuscarIDContactos";
            this.btnBuscarIDContactos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarIDContactos.Size = new System.Drawing.Size(171, 36);
            this.btnBuscarIDContactos.TabIndex = 20;
            this.btnBuscarIDContactos.Text = "buscar por ID";
            this.btnBuscarIDContactos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarIDContactos.UseAccentColor = false;
            this.btnBuscarIDContactos.UseVisualStyleBackColor = true;
            this.btnBuscarIDContactos.Click += new System.EventHandler(this.btnBuscarIDContactos_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1046, 583);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosAgregar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarContactos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarContacto)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private MaterialSkin.Controls.MaterialButton btnAgregarContacto;
        private MaterialSkin.Controls.MaterialTextBox txtCorreoContactoAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoContactoAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoContactoAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvContactosAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNombreContactoAgregar;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriasContactoAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtCorreoContactoModificar;
        private MaterialSkin.Controls.MaterialButton btnModificarContacto;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriaContactoModificar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreContactoModificar;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoContactoModificar;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoContactoModificar;
        private System.Windows.Forms.DataGridView dgvModificarContactos;
        private MaterialSkin.Controls.MaterialTextBox txtIdContactoModificar;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton btnModificarCategoriaContacto;
        private MaterialSkin.Controls.MaterialButton btnModificarTelefonoContacto;
        private MaterialSkin.Controls.MaterialButton btnModificarCorreoContacto;
        private MaterialSkin.Controls.MaterialButton btnModificarApellidoContacto;
        private MaterialSkin.Controls.MaterialTextBox txtEliminarIdContacto;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton btnEliminarIdContacto;
        private System.Windows.Forms.DataGridView dgvEliminarContacto;
        private System.Windows.Forms.Button btnRecargarEliminar;
        private System.Windows.Forms.Button btnRecargarGillaAgregar;
        private System.Windows.Forms.Button btnRecargarGrillaModificar;
        private System.Windows.Forms.DataGridView dgvProductoAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionProductoAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox txtNombreProductoAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriasProductoAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtStockProductoAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioProductoAgregar;
        private MaterialSkin.Controls.MaterialButton btnBuscarIDContactos;
    }
}

