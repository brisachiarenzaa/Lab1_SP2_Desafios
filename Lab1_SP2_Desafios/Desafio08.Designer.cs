namespace Lab1_SP2_Desafios
{
    partial class Desafio08
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkCobertura;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chkCobertura = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkCobertura
            // 
            this.chkCobertura.AutoSize = true;
            this.chkCobertura.Location = new System.Drawing.Point(40, 98);
            this.chkCobertura.Margin = new System.Windows.Forms.Padding(4);
            this.chkCobertura.Name = "chkCobertura";
            this.chkCobertura.Size = new System.Drawing.Size(170, 20);
            this.chkCobertura.TabIndex = 1;
            this.chkCobertura.Text = "Cobertura odontologica";
            this.chkCobertura.ThreeState = true;
            this.chkCobertura.UseVisualStyleBackColor = true;
            this.chkCobertura.CheckStateChanged += new System.EventHandler(this.chkCobertura_CheckStateChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(40, 148);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(527, 37);
            this.lblEstado.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(33, 25);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(533, 55);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Hace clic varias veces sobre la casilla: tiene que pasar por tres estados distint" +
    "os.";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // Desafio08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 215);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.chkCobertura);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Desafio08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 08 - Casilla triestable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
