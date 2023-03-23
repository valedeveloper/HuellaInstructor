
namespace SistemaAsistencia.CapaVistas
{
    partial class FrmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControl));
            this.timerCurrent = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFuncionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFicha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoDedo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.picturePeople = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCurrent
            // 
            this.timerCurrent.Enabled = true;
            this.timerCurrent.Tick += new System.EventHandler(this.timerCurrent_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 58);
            this.panel1.TabIndex = 65;
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
            this.btnClose.Location = new System.Drawing.Point(828, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 61);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Registro Entrada y Salida";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.txtCedula);
            this.panelControl.Controls.Add(this.txtFuncionario);
            this.panelControl.Controls.Add(this.txtFicha);
            this.panelControl.Controls.Add(this.txtNoDedo);
            this.panelControl.Controls.Add(this.txtLastName);
            this.panelControl.Controls.Add(this.txtName);
            this.panelControl.Controls.Add(this.labelEstado);
            this.panelControl.Controls.Add(this.btnEntrar);
            this.panelControl.Controls.Add(this.picturePeople);
            this.panelControl.Controls.Add(this.labelHora);
            this.panelControl.Location = new System.Drawing.Point(47, 124);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(775, 439);
            this.panelControl.TabIndex = 66;
            this.panelControl.Resize += new System.EventHandler(this.panelControl_Resize);
            // 
            // txtCedula
            // 
            this.txtCedula.AutoRoundedCorners = true;
            this.txtCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.txtCedula.BorderRadius = 11;
            this.txtCedula.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCedula.BorderThickness = 2;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.Location = new System.Drawing.Point(356, 47);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCedula.PlaceholderText = "Cédula";
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(219, 24);
            this.txtCedula.TabIndex = 92;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFuncionario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtFuncionario.BorderThickness = 2;
            this.txtFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncionario.DefaultText = "";
            this.txtFuncionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtFuncionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.txtFuncionario.Location = new System.Drawing.Point(356, 162);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.PasswordChar = '\0';
            this.txtFuncionario.PlaceholderText = "Funcionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.SelectedText = "";
            this.txtFuncionario.Size = new System.Drawing.Size(338, 24);
            this.txtFuncionario.TabIndex = 91;
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
            this.txtFicha.Location = new System.Drawing.Point(356, 194);
            this.txtFicha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.PasswordChar = '\0';
            this.txtFicha.PlaceholderText = "Ficha";
            this.txtFicha.ReadOnly = true;
            this.txtFicha.SelectedText = "";
            this.txtFicha.Size = new System.Drawing.Size(338, 24);
            this.txtFicha.TabIndex = 90;
            // 
            // txtNoDedo
            // 
            this.txtNoDedo.AutoRoundedCorners = true;
            this.txtNoDedo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.txtNoDedo.BorderRadius = 11;
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
            this.txtNoDedo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoDedo.Location = new System.Drawing.Point(356, 15);
            this.txtNoDedo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoDedo.Name = "txtNoDedo";
            this.txtNoDedo.PasswordChar = '\0';
            this.txtNoDedo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtNoDedo.PlaceholderText = "Nùmero Dedo\r\n";
            this.txtNoDedo.SelectedText = "";
            this.txtNoDedo.Size = new System.Drawing.Size(120, 24);
            this.txtNoDedo.TabIndex = 85;
            this.txtNoDedo.Visible = false;
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
            this.txtLastName.Location = new System.Drawing.Point(356, 130);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Apellido";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(338, 24);
            this.txtLastName.TabIndex = 89;
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
            this.txtName.Location = new System.Drawing.Point(356, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = " Nombre\r\n";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(338, 24);
            this.txtName.TabIndex = 88;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.labelEstado.Location = new System.Drawing.Point(375, 241);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(281, 37);
            this.labelEstado.TabIndex = 87;
            this.labelEstado.Text = "Entrando/Saliendo";
            // 
            // btnEntrar
            // 
            this.btnEntrar.DefaultAutoSize = true;
            this.btnEntrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEntrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnEntrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.btnEntrar.Location = new System.Drawing.Point(596, 47);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 30);
            this.btnEntrar.TabIndex = 86;
            this.btnEntrar.Text = "Registrar ";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picturePeople
            // 
            this.picturePeople.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePeople.InitialImage")));
            this.picturePeople.Location = new System.Drawing.Point(23, 52);
            this.picturePeople.Name = "picturePeople";
            this.picturePeople.Size = new System.Drawing.Size(307, 226);
            this.picturePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePeople.TabIndex = 84;
            this.picturePeople.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.labelHora.Location = new System.Drawing.Point(31, 318);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(99, 42);
            this.labelHora.TabIndex = 83;
            this.labelHora.Text = "Hora";
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(774, 71);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(48, 47);
            this.verificationControl1.TabIndex = 92;
            this.verificationControl1.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.verificationControl1_OnComplete);
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 627);
            this.Controls.Add(this.verificationControl1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCurrent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelControl;
        public Guna.UI2.WinForms.Guna2TextBox txtFuncionario;
        private Guna.UI2.WinForms.Guna2TextBox txtFicha;
        public Guna.UI2.WinForms.Guna2TextBox txtLastName;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label labelEstado;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox txtNoDedo;
        private System.Windows.Forms.PictureBox picturePeople;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnClose;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
    }
}