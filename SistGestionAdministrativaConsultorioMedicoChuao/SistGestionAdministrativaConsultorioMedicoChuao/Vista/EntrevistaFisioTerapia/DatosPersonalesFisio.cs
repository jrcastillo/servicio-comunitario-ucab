using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia
{
    public partial class TB_CorreoPapa : Form
    {
        public TB_CorreoPapa()
        {
            InitializeComponent();
            setearDatesPickers();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación, de ser así, no se guardaran los datos y volvera al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void setearDatesPickers()
        {
            DTP_FechaNacMama.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacMama.MaxDate = DateTime.Today;
            DTP_FechaNacPapa.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacPapa.MaxDate = DateTime.Today;
            DTP_FechaNacPaciente.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacPaciente.MaxDate = DateTime.Today;
        }

        private void RTB_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*'
                && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_NombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_NombreMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_NombrePapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_CorreoMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '@' 
                && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_CedulaMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_CedulaPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCasaMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCelularMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCasaPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCelularPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_CorreoElectronicoPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '@'
                && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
