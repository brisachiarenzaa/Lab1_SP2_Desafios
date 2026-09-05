namespace Lab1_SP2_Desafios
{
    partial class Desafio07
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.RadioButton optPresencial;
        private System.Windows.Forms.RadioButton optVirtual;
        private System.Windows.Forms.RadioButton optMixta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.optVirtual = new System.Windows.Forms.RadioButton();
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.optNoche = new System.Windows.Forms.RadioButton();
            this.optTarde = new System.Windows.Forms.RadioButton();
            this.optManana = new System.Windows.Forms.RadioButton();
            this.gpbTurno = new System.Windows.Forms.GroupBox();
            this.gpbModalidad = new System.Windows.Forms.GroupBox();
            this.gpbTurno.SuspendLayout();
            this.gpbModalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTurno.Location = new System.Drawing.Point(33, 37);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(300, 37);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(83, 20);
            this.lblModalidad.TabIndex = 1;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.Location = new System.Drawing.Point(53, 252);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(520, 31);
            this.lblSeleccion.TabIndex = 9;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(53, 197);
            this.cmdConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(147, 37);
            this.cmdConfirmar.TabIndex = 8;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // optPresencial
            // 
            this.optPresencial.AutoSize = true;
            this.optPresencial.Location = new System.Drawing.Point(33, 5);
            this.optPresencial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(92, 20);
            this.optPresencial.TabIndex = 5;
            this.optPresencial.Text = "Presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            // 
            // optVirtual
            // 
            this.optVirtual.AutoSize = true;
            this.optVirtual.Location = new System.Drawing.Point(33, 42);
            this.optVirtual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optVirtual.Name = "optVirtual";
            this.optVirtual.Size = new System.Drawing.Size(65, 20);
            this.optVirtual.TabIndex = 6;
            this.optVirtual.Text = "Virtual";
            this.optVirtual.UseVisualStyleBackColor = true;
            // 
            // optMixta
            // 
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(33, 79);
            this.optMixta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(59, 20);
            this.optMixta.TabIndex = 7;
            this.optMixta.Text = "Mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            // 
            // optNoche
            // 
            this.optNoche.AutoSize = true;
            this.optNoche.Location = new System.Drawing.Point(31, 79);
            this.optNoche.Margin = new System.Windows.Forms.Padding(4);
            this.optNoche.Name = "optNoche";
            this.optNoche.Size = new System.Drawing.Size(68, 20);
            this.optNoche.TabIndex = 4;
            this.optNoche.Text = "Noche";
            this.optNoche.UseVisualStyleBackColor = true;
            // 
            // optTarde
            // 
            this.optTarde.AutoSize = true;
            this.optTarde.Location = new System.Drawing.Point(31, 42);
            this.optTarde.Margin = new System.Windows.Forms.Padding(4);
            this.optTarde.Name = "optTarde";
            this.optTarde.Size = new System.Drawing.Size(65, 20);
            this.optTarde.TabIndex = 3;
            this.optTarde.Text = "Tarde";
            this.optTarde.UseVisualStyleBackColor = true;
            // 
            // optManana
            // 
            this.optManana.AutoSize = true;
            this.optManana.Location = new System.Drawing.Point(31, 5);
            this.optManana.Margin = new System.Windows.Forms.Padding(4);
            this.optManana.Name = "optManana";
            this.optManana.Size = new System.Drawing.Size(77, 20);
            this.optManana.TabIndex = 2;
            this.optManana.Text = "Manana";
            this.optManana.UseVisualStyleBackColor = true;
            // 
            // gpbTurno
            // 
            this.gpbTurno.Controls.Add(this.optManana);
            this.gpbTurno.Controls.Add(this.optTarde);
            this.gpbTurno.Controls.Add(this.optNoche);
            this.gpbTurno.Location = new System.Drawing.Point(37, 62);
            this.gpbTurno.Name = "gpbTurno";
            this.gpbTurno.Size = new System.Drawing.Size(177, 128);
            this.gpbTurno.TabIndex = 10;
            this.gpbTurno.TabStop = false;
            // 
            // gpbModalidad
            // 
            this.gpbModalidad.Controls.Add(this.optPresencial);
            this.gpbModalidad.Controls.Add(this.optVirtual);
            this.gpbModalidad.Controls.Add(this.optMixta);
            this.gpbModalidad.Location = new System.Drawing.Point(287, 69);
            this.gpbModalidad.Name = "gpbModalidad";
            this.gpbModalidad.Size = new System.Drawing.Size(167, 120);
            this.gpbModalidad.TabIndex = 11;
            this.gpbModalidad.TabStop = false;
            // 
            // Desafio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 308);
            this.Controls.Add(this.gpbModalidad);
            this.Controls.Add(this.gpbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.lblSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Desafio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 07 - Botones de opcion";
            this.gpbTurno.ResumeLayout(false);
            this.gpbTurno.PerformLayout();
            this.gpbModalidad.ResumeLayout(false);
            this.gpbModalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RadioButton optNoche;
        private System.Windows.Forms.RadioButton optTarde;
        private System.Windows.Forms.RadioButton optManana;
        private System.Windows.Forms.GroupBox gpbTurno;
        private System.Windows.Forms.GroupBox gpbModalidad;
    }
}
