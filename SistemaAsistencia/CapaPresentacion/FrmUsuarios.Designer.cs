
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sistema_de_AsistenciaDataSet = new SistemaAsistencia.Sistema_de_AsistenciaDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaAsistencia.Sistema_de_AsistenciaDataSetTableAdapters.USUARIOSTableAdapter();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
            this.panel2.SuspendLayout();
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
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.Controls.Add(this.btnModificar);
            this.panelUsuario.Controls.Add(this.btnAgregar);
            this.panelUsuario.Controls.Add(this.dataUsuario);
            this.panelUsuario.Controls.Add(this.label1);
            this.panelUsuario.Location = new System.Drawing.Point(62, 120);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(764, 468);
            this.panelUsuario.TabIndex = 49;
            this.panelUsuario.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(199, 403);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 34);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataUsuario
            // 
            this.dataUsuario.AllowUserToAddRows = false;
            this.dataUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataUsuario.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUsuario.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataUsuario.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataUsuario.Location = new System.Drawing.Point(64, 186);
            this.dataUsuario.Name = "dataUsuario";
            this.dataUsuario.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataUsuario.RowHeadersVisible = false;
            this.dataUsuario.Size = new System.Drawing.Size(641, 170);
            this.dataUsuario.TabIndex = 33;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(292, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuarios";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(828, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 61);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 61);
            this.panel2.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Usuarios del Sistema";
            // 
            // btnModificar
            // 
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(399, 403);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 34);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sistema_de_AsistenciaDataSet sistema_de_AsistenciaDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private Sistema_de_AsistenciaDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.Panel panelUsuario;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
    }
}