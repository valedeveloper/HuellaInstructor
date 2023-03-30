
namespace SistemaAsistencia.CapaVistas
{
    partial class FrmAgregarPersona
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoDedo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.comboFuncionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFicha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.btnOpen = new Guna.UI2.WinForms.Guna2Button();
            this.txtFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 61);
            this.panel1.TabIndex = 67;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(855, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 61);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Agregar Persona";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNoDedo);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.comboFuncionario);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtFicha);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(62, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 335);
            this.panel2.TabIndex = 68;
            // 
            // txtNoDedo
            // 
            this.txtNoDedo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtNoDedo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNoDedo.BorderThickness = 2;
            this.txtNoDedo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoDedo.DefaultText = "";
            this.txtNoDedo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoDedo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoDedo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoDedo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoDedo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtNoDedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoDedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtNoDedo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtNoDedo.Location = new System.Drawing.Point(112, 49);
            this.txtNoDedo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoDedo.Name = "txtNoDedo";
            this.txtNoDedo.PasswordChar = '\0';
            this.txtNoDedo.PlaceholderText = "No Dedo";
            this.txtNoDedo.SelectedText = "";
            this.txtNoDedo.Size = new System.Drawing.Size(83, 24);
            this.txtNoDedo.TabIndex = 53;
            this.txtNoDedo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DefaultAutoSize = true;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(423, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 30);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
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
            this.btnAgregar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnAgregar.Location = new System.Drawing.Point(319, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.comboFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.comboFuncionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuncionario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.comboFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboFuncionario.ItemHeight = 30;
            this.comboFuncionario.Items.AddRange(new object[] {
            "Aprendiz",
            "Instructor",
            "Funcionario "});
            this.comboFuncionario.Location = new System.Drawing.Point(365, 193);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(155, 36);
            this.comboFuncionario.TabIndex = 48;
            this.comboFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboFuncionario_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtTelefono.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTelefono.BorderThickness = 2;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtTelefono.Location = new System.Drawing.Point(477, 113);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Ingresa el Teléfono\r\n";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(215, 24);
            this.txtTelefono.TabIndex = 47;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtFicha
            // 
            this.txtFicha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFicha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtFicha.BorderThickness = 2;
            this.txtFicha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFicha.DefaultText = "";
            this.txtFicha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFicha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFicha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFicha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFicha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFicha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFicha.Location = new System.Drawing.Point(477, 145);
            this.txtFicha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.PasswordChar = '\0';
            this.txtFicha.PlaceholderText = "Ingresa la Ficha";
            this.txtFicha.SelectedText = "";
            this.txtFicha.Size = new System.Drawing.Size(215, 24);
            this.txtFicha.TabIndex = 46;
            this.txtFicha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFicha_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCorreo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCorreo.BorderThickness = 2;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtCorreo.Location = new System.Drawing.Point(477, 81);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "Ingresa el Correo\r\n";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(215, 24);
            this.txtCorreo.TabIndex = 45;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress_1);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtLastName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtLastName.BorderThickness = 2;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtLastName.Location = new System.Drawing.Point(112, 145);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Ingresa el Apellido";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(215, 24);
            this.txtLastName.TabIndex = 44;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtName.Location = new System.Drawing.Point(112, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Ingresa el Nombre\r\n";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(215, 24);
            this.txtName.TabIndex = 43;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress_1);
            // 
            // txtCedula
            // 
            this.txtCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCedula.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCedula.BorderThickness = 2;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtCedula.Location = new System.Drawing.Point(112, 81);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderText = "Ingresa la Cédula";
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(215, 24);
            this.txtCedula.TabIndex = 42;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(248, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Funcionario:";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(62, 107);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 69;
            this.enrollmentControl1.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollmentControl1_OnDelete);
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
            // 
            // btnOpen
            // 
            this.btnOpen.BorderRadius = 10;
            this.btnOpen.DefaultAutoSize = true;
            this.btnOpen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(831, 341);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 26);
            this.btnOpen.TabIndex = 73;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFile
            // 
            this.txtFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFile.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtFile.BorderThickness = 2;
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.DefaultText = "";
            this.txtFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFile.Location = new System.Drawing.Point(612, 342);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.PlaceholderText = "\r\n";
            this.txtFile.SelectedText = "";
            this.txtFile.Size = new System.Drawing.Size(212, 24);
            this.txtFile.TabIndex = 72;
            this.txtFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFile_KeyPress_1);
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(612, 152);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(212, 166);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 71;
            this.pictureUser.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(567, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "File :";
            // 
            // FrmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 788);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enrollmentControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNoDedo;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2ComboBox comboFuncionario;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtFicha;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        private Guna.UI2.WinForms.Guna2Button btnOpen;
        private Guna.UI2.WinForms.Guna2TextBox txtFile;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label label7;
    }
}