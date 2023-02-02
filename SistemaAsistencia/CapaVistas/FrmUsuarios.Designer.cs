
namespace SistemaAsistencia.CapaVistas
{
    partial class FrmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.sistema_de_AsistenciaDataSet = new SistemaAsistencia.Sistema_de_AsistenciaDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaAsistencia.Sistema_de_AsistenciaDataSetTableAdapters.USUARIOSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionImagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoUsuarioDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sistema_de_AsistenciaDataSet
            // 
            this.sistema_de_AsistenciaDataSet.DataSetName = "Sistema_de_AsistenciaDataSet";
            this.sistema_de_AsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sistema_de_AsistenciaDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(239, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 43);
            this.label1.TabIndex = 27;
            this.label1.Text = "Usuarios";
            // 
            // dataUsuario
            // 
            this.dataUsuario.AllowUserToAddRows = false;
            this.dataUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUsuario.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataUsuario.ColumnHeadersHeight = 20;
            this.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.cedulaUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.apellidoUsuarioDataGridViewTextBoxColumn,
            this.correoUsuarioDataGridViewTextBoxColumn,
            this.celularUsuarioDataGridViewTextBoxColumn,
            this.passwordUsuarioDataGridViewTextBoxColumn,
            this.rolUsuarioDataGridViewTextBoxColumn,
            this.estadoUsuarioDataGridViewTextBoxColumn,
            this.direccionImagenDataGridViewTextBoxColumn,
            this.photoUsuarioDataGridViewImageColumn});
            this.dataUsuario.DataSource = this.uSUARIOSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataUsuario.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataUsuario.Location = new System.Drawing.Point(57, 261);
            this.dataUsuario.Name = "dataUsuario";
            this.dataUsuario.ReadOnly = true;
            this.dataUsuario.RowHeadersVisible = false;
            this.dataUsuario.Size = new System.Drawing.Size(641, 170);
            this.dataUsuario.TabIndex = 28;
            this.dataUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataUsuario.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataUsuario.ThemeStyle.HeaderStyle.Height = 20;
            this.dataUsuario.ThemeStyle.ReadOnly = true;
            this.dataUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataUsuario.ThemeStyle.RowsStyle.Height = 22;
            this.dataUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // cedulaUsuarioDataGridViewTextBoxColumn
            // 
            this.cedulaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Usuario";
            this.cedulaUsuarioDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaUsuarioDataGridViewTextBoxColumn.Name = "cedulaUsuarioDataGridViewTextBoxColumn";
            this.cedulaUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoUsuarioDataGridViewTextBoxColumn
            // 
            this.apellidoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Usuario";
            this.apellidoUsuarioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoUsuarioDataGridViewTextBoxColumn.Name = "apellidoUsuarioDataGridViewTextBoxColumn";
            this.apellidoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoUsuarioDataGridViewTextBoxColumn
            // 
            this.correoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Correo_Usuario";
            this.correoUsuarioDataGridViewTextBoxColumn.HeaderText = "Correo_Usuario";
            this.correoUsuarioDataGridViewTextBoxColumn.Name = "correoUsuarioDataGridViewTextBoxColumn";
            this.correoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // celularUsuarioDataGridViewTextBoxColumn
            // 
            this.celularUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Celular_Usuario";
            this.celularUsuarioDataGridViewTextBoxColumn.HeaderText = "Celular_Usuario";
            this.celularUsuarioDataGridViewTextBoxColumn.Name = "celularUsuarioDataGridViewTextBoxColumn";
            this.celularUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordUsuarioDataGridViewTextBoxColumn
            // 
            this.passwordUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Password_Usuario";
            this.passwordUsuarioDataGridViewTextBoxColumn.HeaderText = "Password_Usuario";
            this.passwordUsuarioDataGridViewTextBoxColumn.Name = "passwordUsuarioDataGridViewTextBoxColumn";
            this.passwordUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolUsuarioDataGridViewTextBoxColumn
            // 
            this.rolUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Rol_Usuario";
            this.rolUsuarioDataGridViewTextBoxColumn.HeaderText = "Rol_Usuario";
            this.rolUsuarioDataGridViewTextBoxColumn.Name = "rolUsuarioDataGridViewTextBoxColumn";
            this.rolUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoUsuarioDataGridViewTextBoxColumn
            // 
            this.estadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Usuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.HeaderText = "Estado_Usuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.Name = "estadoUsuarioDataGridViewTextBoxColumn";
            this.estadoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionImagenDataGridViewTextBoxColumn
            // 
            this.direccionImagenDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Imagen";
            this.direccionImagenDataGridViewTextBoxColumn.HeaderText = "Direccion_Imagen";
            this.direccionImagenDataGridViewTextBoxColumn.Name = "direccionImagenDataGridViewTextBoxColumn";
            this.direccionImagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionImagenDataGridViewTextBoxColumn.Visible = false;
            // 
            // photoUsuarioDataGridViewImageColumn
            // 
            this.photoUsuarioDataGridViewImageColumn.DataPropertyName = "Photo_Usuario";
            this.photoUsuarioDataGridViewImageColumn.HeaderText = "Photo_Usuario";
            this.photoUsuarioDataGridViewImageColumn.Name = "photoUsuarioDataGridViewImageColumn";
            this.photoUsuarioDataGridViewImageColumn.ReadOnly = true;
            this.photoUsuarioDataGridViewImageColumn.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(219, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 34);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Animated = true;
            this.btnModificar.AutoRoundedCorners = true;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 16;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(61)))), ((int)(((byte)(238)))));
            this.btnModificar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IndicateFocus = true;
            this.btnModificar.Location = new System.Drawing.Point(424, 465);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 34);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.InitialImage")));
            this.pictureUser.Location = new System.Drawing.Point(493, 83);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(149, 144);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 31;
            this.pictureUser.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sistema_de_AsistenciaDataSet sistema_de_AsistenciaDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private Sistema_de_AsistenciaDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DataGridView dataUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionImagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoUsuarioDataGridViewImageColumn;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private System.Windows.Forms.PictureBox pictureUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}