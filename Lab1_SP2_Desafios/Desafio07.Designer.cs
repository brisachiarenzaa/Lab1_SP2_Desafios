namespace Lab1_SP2_Desafios
{
    partial class Desafio07
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.RadioButton optManana;
        private System.Windows.Forms.RadioButton optTarde;
        private System.Windows.Forms.RadioButton optNoche;
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
            this.optManana = new System.Windows.Forms.RadioButton();
            this.optTarde = new System.Windows.Forms.RadioButton();
            this.optNoche = new System.Windows.Forms.RadioButton();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.optVirtual = new System.Windows.Forms.RadioButton();
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTurno.Location = new System.Drawing.Point(25, 30);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 15);
            this.lblTurno.Text = "Turno";
            this.Controls.Add(this.lblTurno);
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(225, 30);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(70, 15);
            this.lblModalidad.Text = "Modalidad";
            this.Controls.Add(this.lblModalidad);
            this.optManana.AutoSize = true;
            this.optManana.Location = new System.Drawing.Point(40, 60);
            this.optManana.Name = "optManana";
            this.optManana.Size = new System.Drawing.Size(90, 17);
            this.optManana.Text = "Manana";
            this.optManana.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optManana);
            this.optTarde.AutoSize = true;
            this.optTarde.Location = new System.Drawing.Point(40, 90);
            this.optTarde.Name = "optTarde";
            this.optTarde.Size = new System.Drawing.Size(90, 17);
            this.optTarde.Text = "Tarde";
            this.optTarde.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optTarde);
            this.optNoche.AutoSize = true;
            this.optNoche.Location = new System.Drawing.Point(40, 120);
            this.optNoche.Name = "optNoche";
            this.optNoche.Size = new System.Drawing.Size(90, 17);
            this.optNoche.Text = "Noche";
            this.optNoche.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optNoche);
            this.optPresencial.AutoSize = true;
            this.optPresencial.Location = new System.Drawing.Point(240, 60);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(90, 17);
            this.optPresencial.Text = "Presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optPresencial);
            this.optVirtual.AutoSize = true;
            this.optVirtual.Location = new System.Drawing.Point(240, 90);
            this.optVirtual.Name = "optVirtual";
            this.optVirtual.Size = new System.Drawing.Size(90, 17);
            this.optVirtual.Text = "Virtual";
            this.optVirtual.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optVirtual);
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(240, 120);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(90, 17);
            this.optMixta.Text = "Mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            this.Controls.Add(this.optMixta);
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(40, 160);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 30);
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            this.Controls.Add(this.cmdConfirmar);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.Location = new System.Drawing.Point(40, 205);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(390, 25);
            this.lblSeleccion.Text = "";
            this.Controls.Add(this.lblSeleccion);
            // 
            // Desafio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 07 - Botones de opcion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
