
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
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picturePeople = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFicha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureSena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSena)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCurrent
            // 
            this.timerCurrent.Enabled = true;
            this.timerCurrent.Tick += new System.EventHandler(this.timerCurrent_Tick);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.labelHora.Location = new System.Drawing.Point(123, 165);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(86, 31);
            this.labelHora.TabIndex = 35;
            this.labelHora.Text = "Hora";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelFecha.Location = new System.Drawing.Point(123, 122);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(68, 29);
            this.labelFecha.TabIndex = 37;
            this.labelFecha.Text = "Hora";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // picturePeople
            // 
            this.picturePeople.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePeople.InitialImage")));
            this.picturePeople.Location = new System.Drawing.Point(450, 322);
            this.picturePeople.Name = "picturePeople";
            this.picturePeople.Size = new System.Drawing.Size(212, 166);
            this.picturePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePeople.TabIndex = 39;
            this.picturePeople.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoRoundedCorners = true;
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.txtCodigo.BorderRadius = 11;
            this.txtCodigo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCodigo.BorderThickness = 2;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Location = new System.Drawing.Point(127, 233);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCodigo.PlaceholderText = "Ingrese Código de Barras";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(219, 24);
            this.txtCodigo.TabIndex = 40;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BorderRadius = 10;
            this.btnEntrar.DefaultAutoSize = true;
            this.btnEntrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEntrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnEntrar.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(371, 227);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 30);
            this.btnEntrar.TabIndex = 41;
            this.btnEntrar.Text = "Registrar ";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelName.Location = new System.Drawing.Point(115, 322);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(13, 18);
            this.labelName.TabIndex = 57;
            this.labelName.Text = ".";
            this.labelName.Visible = false;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelLastName.Location = new System.Drawing.Point(115, 352);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(13, 18);
            this.labelLastName.TabIndex = 58;
            this.labelLastName.Text = ".";
            this.labelLastName.Visible = false;
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelFuncionario.Location = new System.Drawing.Point(257, 408);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(12, 18);
            this.labelFuncionario.TabIndex = 59;
            this.labelFuncionario.Text = ".";
            this.labelFuncionario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(115, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ficha Técnica:";
            // 
            // labelFicha
            // 
            this.labelFicha.AutoSize = true;
            this.labelFicha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.labelFicha.Location = new System.Drawing.Point(257, 445);
            this.labelFicha.Name = "labelFicha";
            this.labelFicha.Size = new System.Drawing.Size(12, 18);
            this.labelFicha.TabIndex = 62;
            this.labelFicha.Text = ".";
            this.labelFicha.Visible = false;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.labelEstado.Location = new System.Drawing.Point(245, 528);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(282, 31);
            this.labelEstado.TabIndex = 63;
            this.labelEstado.Text = "Entrando/Saliendo";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(733, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 41);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureSena);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 85);
            this.panel1.TabIndex = 65;
            // 
            // pictureSena
            // 
            this.pictureSena.Image = ((System.Drawing.Image)(resources.GetObject("pictureSena.Image")));
            this.pictureSena.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureSena.InitialImage")));
            this.pictureSena.Location = new System.Drawing.Point(52, 0);
            this.pictureSena.Name = "pictureSena";
            this.pictureSena.Size = new System.Drawing.Size(118, 85);
            this.pictureSena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSena.TabIndex = 42;
            this.pictureSena.TabStop = false;
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelFicha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFuncionario);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.picturePeople);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCurrent;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox picturePeople;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFicha;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureSena;
    }
}