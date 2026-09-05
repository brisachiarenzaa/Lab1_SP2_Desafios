                     namespace Lab1_SP2_Desafios
{
    partial class Desafio06
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.Button cmdLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Apellido:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(33, 142);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(520, 31);
            this.lblResultado.TabIndex = 0;
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Location = new System.Drawing.Point(127, 80);
            this.cmdProcesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(140, 37);
            this.cmdProcesar.TabIndex = 2;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(280, 80);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(140, 37);
            this.cmdLimpiar.TabIndex = 1;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // Desafio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 203);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdProcesar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Desafio06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 06 - Label vs TextBox";
            this.Load += new System.EventHandler(this.Desafio06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
