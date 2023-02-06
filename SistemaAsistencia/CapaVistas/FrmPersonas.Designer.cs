
namespace SistemaAsistencia.CapaVistas
{
    partial class FrmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPersona = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picturePeople = new System.Windows.Forms.PictureBox();
            this.pERSONASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_AsistenciaDataSet = new SistemaAsistencia.Sistema_de_AsistenciaDataSet();
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASTableAdapter = new SistemaAsistencia.Sistema_de_AsistenciaDataSetTableAdapters.PERSONASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(239, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 43);
            this.label2.TabIndex = 34;
            this.label2.Text = "Personas";
            // 
            // dataPersona
            // 
            this.dataPersona.AllowUserToAddRows = false;
            this.dataPersona.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataPersona.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPersona.ColumnHeadersHeight = 20;
            this.dataPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPersona.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataPersona.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataPersona.Location = new System.Drawing.Point(57, 261);
            this.dataPersona.Name = "dataPersona";
            this.dataPersona.ReadOnly = true;
            this.dataPersona.RowHeadersVisible = false;
            this.dataPersona.Size = new System.Drawing.Size(641, 171);
            this.dataPersona.TabIndex = 35;
            this.dataPersona.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPersona.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataPersona.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataPersona.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataPersona.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataPersona.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataPersona.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataPersona.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataPersona.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPersona.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPersona.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataPersona.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataPersona.ThemeStyle.HeaderStyle.Height = 20;
            this.dataPersona.ThemeStyle.ReadOnly = true;
            this.dataPersona.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPersona.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataPersona.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPersona.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPersona.ThemeStyle.RowsStyle.Height = 22;
            this.dataPersona.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPersona.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(219, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 34);
            this.btnAgregar.TabIndex = 36;
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
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // picturePeople
            // 
            this.picturePeople.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePeople.InitialImage")));
            this.picturePeople.Location = new System.Drawing.Point(493, 83);
            this.picturePeople.Name = "picturePeople";
            this.picturePeople.Size = new System.Drawing.Size(149, 144);
            this.picturePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePeople.TabIndex = 38;
            this.picturePeople.TabStop = false;
            // 
            // pERSONASBindingSource1
            // 
            this.pERSONASBindingSource1.DataMember = "PERSONAS";
            this.pERSONASBindingSource1.DataSource = this.sistema_de_AsistenciaDataSet;
            // 
            // sistema_de_AsistenciaDataSet
            // 
            this.sistema_de_AsistenciaDataSet.DataSetName = "Sistema_de_AsistenciaDataSet";
            this.sistema_de_AsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            // 
            // pERSONASTableAdapter
            // 
            this.pERSONASTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 600);
            this.Controls.Add(this.picturePeople);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonas";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_AsistenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2DataGridView dataPersona;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox picturePeople;
        private System.Windows.Forms.BindingSource pERSONASBindingSource1;
        private Sistema_de_AsistenciaDataSet sistema_de_AsistenciaDataSet;
        private System.Windows.Forms.BindingSource pERSONASBindingSource;
        private Sistema_de_AsistenciaDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter;
    }
}