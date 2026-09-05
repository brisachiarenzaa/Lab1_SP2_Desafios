namespace Lab1_SP2_Desafios
{
    partial class Desafio10
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblAviso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(600, 28);
            this.mnuPrincipal.TabIndex = 3;
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGuardarComo,
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(73, 24);
            this.mnuArchivo.Text = "&Archivo";
            // 
            // mnuGuardarComo
            // 
            this.mnuGuardarComo.Name = "mnuGuardarComo";
            this.mnuGuardarComo.Size = new System.Drawing.Size(187, 26);
            this.mnuGuardarComo.Text = "Guardar como";
            this.mnuGuardarComo.Click += new System.EventHandler(this.mnuGuardarComo_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(187, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(33, 68);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(144, 16);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo (solo numeros):";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(213, 64);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(199, 22);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // lblAviso
            // 
            this.lblAviso.Location = new System.Drawing.Point(33, 117);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(533, 55);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Proba escribir letras en el legajo: hoy las acepta y no deberia.";
            // 
            // Desafio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 203);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Desafio10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 10 - Tecla pulsada y menu";
            this.Load += new System.EventHandler(this.Desafio10_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
