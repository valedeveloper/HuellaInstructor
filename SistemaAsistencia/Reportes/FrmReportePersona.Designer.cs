
namespace SistemaAsistencia.Reportes
{
    partial class FrmReportePersona
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
            this.crystalReportPersona = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportePersona1 = new SistemaAsistencia.Reportes.ReportePersona();
            this.SuspendLayout();
            // 
            // crystalReportPersona
            // 
            this.crystalReportPersona.ActiveViewIndex = 0;
            this.crystalReportPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPersona.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportPersona.Location = new System.Drawing.Point(0, 0);
            this.crystalReportPersona.Name = "crystalReportPersona";
            this.crystalReportPersona.ReportSource = this.ReportePersona1;
            this.crystalReportPersona.Size = new System.Drawing.Size(800, 450);
            this.crystalReportPersona.TabIndex = 0;
            this.crystalReportPersona.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReportePersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Persona";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPersona;
        private ReportePersona ReportePersona1;
    }
}