
namespace SistemaAsistencia
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.imageUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imagePerson = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageControl = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageReporte = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureSena = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSena)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema Control de Asistencia";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.InitialImage")));
            this.pictureUser.Location = new System.Drawing.Point(594, 20);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(46, 46);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 40;
            this.pictureUser.TabStop = false;
            this.pictureUser.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(646, 39);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 16);
            this.labelNombre.TabIndex = 41;
            this.labelNombre.Text = "Usuario";
            this.labelNombre.Visible = false;
            // 
            // imageUser
            // 
            this.imageUser.BackColor = System.Drawing.Color.Transparent;
            this.imageUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageUser.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.imageUser.Image = ((System.Drawing.Image)(resources.GetObject("imageUser.Image")));
            this.imageUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.imageUser.ImageRotate = 0F;
            this.imageUser.ImageSize = new System.Drawing.Size(150, 150);
            this.imageUser.Location = new System.Drawing.Point(51, 301);
            this.imageUser.Name = "imageUser";
            this.imageUser.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageUser.Size = new System.Drawing.Size(185, 136);
            this.imageUser.TabIndex = 42;
            this.imageUser.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // imagePerson
            // 
            this.imagePerson.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imagePerson.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.imagePerson.Image = ((System.Drawing.Image)(resources.GetObject("imagePerson.Image")));
            this.imagePerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagePerson.ImageRotate = 0F;
            this.imagePerson.ImageSize = new System.Drawing.Size(150, 150);
            this.imagePerson.Location = new System.Drawing.Point(242, 290);
            this.imagePerson.Name = "imagePerson";
            this.imagePerson.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imagePerson.Size = new System.Drawing.Size(166, 163);
            this.imagePerson.TabIndex = 43;
            this.imagePerson.Click += new System.EventHandler(this.guna2Shapes2_Click);
            // 
            // imageControl
            // 
            this.imageControl.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageControl.HoverState.ImageSize = new System.Drawing.Size(160, 160);
            this.imageControl.Image = ((System.Drawing.Image)(resources.GetObject("imageControl.Image")));
            this.imageControl.ImageOffset = new System.Drawing.Point(0, 0);
            this.imageControl.ImageRotate = 0F;
            this.imageControl.ImageSize = new System.Drawing.Size(150, 150);
            this.imageControl.Location = new System.Drawing.Point(440, 290);
            this.imageControl.Name = "imageControl";
            this.imageControl.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageControl.Size = new System.Drawing.Size(138, 147);
            this.imageControl.TabIndex = 44;
            this.imageControl.Click += new System.EventHandler(this.imageControl_Click);
            // 
            // imageReporte
            // 
            this.imageReporte.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageReporte.HoverState.ImageSize = new System.Drawing.Size(160, 160);
            this.imageReporte.Image = ((System.Drawing.Image)(resources.GetObject("imageReporte.Image")));
            this.imageReporte.ImageOffset = new System.Drawing.Point(0, 0);
            this.imageReporte.ImageRotate = 0F;
            this.imageReporte.ImageSize = new System.Drawing.Size(150, 150);
            this.imageReporte.Location = new System.Drawing.Point(612, 290);
            this.imageReporte.Name = "imageReporte";
            this.imageReporte.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imageReporte.Size = new System.Drawing.Size(143, 147);
            this.imageReporte.TabIndex = 45;
            this.imageReporte.Click += new System.EventHandler(this.imageReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureSena);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 85);
            this.panel1.TabIndex = 46;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(733, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 41);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 50;
            this.guna2Elipse2.TargetControl = this.pictureUser;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageReporte);
            this.Controls.Add(this.imageControl);
            this.Controls.Add(this.imagePerson);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureUser;
        public System.Windows.Forms.Label labelNombre;
        private Guna.UI2.WinForms.Guna2ImageButton imageUser;
        private Guna.UI2.WinForms.Guna2ImageButton imagePerson;
        private Guna.UI2.WinForms.Guna2ImageButton imageReporte;
        private Guna.UI2.WinForms.Guna2ImageButton imageControl;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureSena;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Button btnClose;
    }
}