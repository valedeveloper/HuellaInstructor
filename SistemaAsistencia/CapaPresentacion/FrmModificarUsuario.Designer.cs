
namespace SistemaAsistencia.CapaVistas
{
    partial class FrmModificarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.comboEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combotxtRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Modificar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 61);
            this.panel1.TabIndex = 66;
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
            this.btnClose.Location = new System.Drawing.Point(828, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 61);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.comboEstado);
            this.panel2.Controls.Add(this.combotxtRol);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.txtFile);
            this.panel2.Controls.Add(this.pictureUser);
            this.panel2.Location = new System.Drawing.Point(44, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 282);
            this.panel2.TabIndex = 68;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelId.Location = new System.Drawing.Point(377, 7);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 18);
            this.labelId.TabIndex = 84;
            this.labelId.Visible = false;
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.Transparent;
            this.comboEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.comboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.comboEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.comboEstado.ItemHeight = 30;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstado.Location = new System.Drawing.Point(549, 240);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(155, 36);
            this.comboEstado.TabIndex = 83;
            // 
            // combotxtRol
            // 
            this.combotxtRol.BackColor = System.Drawing.Color.Transparent;
            this.combotxtRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.combotxtRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combotxtRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotxtRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.combotxtRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.combotxtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotxtRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.combotxtRol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.combotxtRol.ItemHeight = 30;
            this.combotxtRol.Items.AddRange(new object[] {
            "Administrador"});
            this.combotxtRol.Location = new System.Drawing.Point(549, 174);
            this.combotxtRol.Name = "combotxtRol";
            this.combotxtRol.Size = new System.Drawing.Size(155, 36);
            this.combotxtRol.TabIndex = 82;
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
            this.txtTelefono.Location = new System.Drawing.Point(578, 108);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Ingresa el Teléfono\r\n";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(178, 24);
            this.txtTelefono.TabIndex = 81;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtPassword.Location = new System.Drawing.Point(578, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Ingresa la Contraseña\r\n";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(178, 24);
            this.txtPassword.TabIndex = 80;
            this.txtPassword.UseSystemPasswordChar = true;
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
            this.txtCorreo.Location = new System.Drawing.Point(578, 44);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "Ingresa el Correo\r\n";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(178, 24);
            this.txtCorreo.TabIndex = 79;
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
            this.txtLastName.Location = new System.Drawing.Point(380, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Ingresa el Apellido";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(178, 24);
            this.txtLastName.TabIndex = 78;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
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
            this.txtName.Location = new System.Drawing.Point(380, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Ingresa el Nombre\r\n";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(178, 24);
            this.txtName.TabIndex = 77;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
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
            this.txtCedula.Location = new System.Drawing.Point(380, 44);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderText = "Ingresa la Cédula";
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(178, 24);
            this.txtCedula.TabIndex = 76;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(387, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Estado de Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(21, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "File :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(412, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Rol de Usuario:";
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
            this.btnOpen.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(285, 193);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(59, 25);
            this.btnOpen.TabIndex = 72;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(181, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 30);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DefaultAutoSize = true;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnModificar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnModificar.Location = new System.Drawing.Point(66, 246);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 30);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.txtFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFile.Location = new System.Drawing.Point(66, 194);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.PlaceholderText = "\r\n";
            this.txtFile.SelectedText = "";
            this.txtFile.Size = new System.Drawing.Size(212, 24);
            this.txtFile.TabIndex = 69;
            this.txtFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFile_KeyPress);
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(66, 7);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(212, 166);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 68;
            this.pictureUser.TabStop = false;
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelId;
        public Guna.UI2.WinForms.Guna2ComboBox comboEstado;
        public Guna.UI2.WinForms.Guna2ComboBox combotxtRol;
        public Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        public Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        public Guna.UI2.WinForms.Guna2TextBox txtLastName;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Guna.UI2.WinForms.Guna2TextBox txtCedula;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Button btnOpen;
        public Guna.UI2.WinForms.Guna2Button btnCancelar;
        public Guna.UI2.WinForms.Guna2Button btnModificar;
        public Guna.UI2.WinForms.Guna2TextBox txtFile;
        public System.Windows.Forms.PictureBox pictureUser;
    }
}