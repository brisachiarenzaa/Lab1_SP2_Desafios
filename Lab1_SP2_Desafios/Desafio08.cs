// =====================================================================
//  DESAFIO 08 - Casilla de verificacion triestable
//  Unidad: SP2 / H2 - Controles
//  Tipo: Codigo faltante (TODO)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  La casilla ya esta configurada como triestable en el Designer, pero el
//  manejador del evento no hace nada.
//  
//  Segun el material, una casilla triestable puede estar activada,
//  desactivada o en un tercer estado intermedio (indeterminado), que se usa
//  cuando el dato no esta definido.
//  
//  Objetivo: completar el switch para que lblEstado muestre
//  'Cobertura: SI' / 'Cobertura: NO' / 'Cobertura: sin definir'.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio08 : Form
    {
        public Desafio08()
        {
            InitializeComponent();
        }

        private void chkCobertura_CheckStateChanged(object sender, EventArgs e)
        {
            lblEstado.Text = "Cobertura: SI";
            lblEstado.Text = "Cobertura: NO";
            lblEstado.Text = "Cobertura: sin definir";

            switch (chkCobertura.CheckState)
            {
                // TODO 1: caso activada  -> lblEstado.Text = "Cobertura: SI";
                // TODO 2: caso desactivada -> lblEstado.Text = "Cobertura: NO";
                // TODO 3: caso indeterminado -> lblEstado.Text = "Cobertura: sin definir";

                case CheckState.Checked :
                    lblEstado.Text = "Cobertura: SI";
                    break;

                case CheckState.Indeterminate:
                    lblEstado.Text = "Cobertura: NO";
                    break;
                case CheckState.Unchecked:
                 lblEstado.Text = "Cobertura: Sin definir";
                    break;
            default:
                   lblEstado.Text = "(Sin resolver)";
                break;
            }
        }
        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void Desafio08_Load(object sender, EventArgs e)
        {

        }

        private void chkCobertura_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
