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
    public partial class ReferenciaEntrevista : Form
    {
        public ReferenciaEntrevista()
        {
            InitializeComponent();
            cargaDatos();
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

        private void B_Siguiente_Click(object sender, EventArgs e)
        {
            bool camposValidos = validarCamposObligados();

            if (camposValidos)
            {
                llenaDatos();
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos();
                nuevaVentana.Show();
                this.Close();
            }
            else
                MessageBox.Show(mensajeError(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void B_Anterior_Click(object sender, EventArgs e)
        {
            llenaDatos();
            SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.DatosPersonalesFisio nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.DatosPersonalesFisio();
            nuevaVentana.Show();
            this.Close();
        }

        private bool validarCamposObligados() 
        {
            bool valido = false;

            if (!TB_Referido.Text.Equals("") && !RTB_Medicamentos.Text.Equals(""))
                valido = true;

            return valido;
        }

        private string mensajeError()
        {
            string mensaje = "";

            if (TB_Referido.Text.Equals("") && RTB_RazonReferencia.Text.Equals(""))
                mensaje = "Debe indicar por quien fue referido el paciente y el motivo";
            else
                if (TB_Referido.Text.Equals(""))
                    mensaje = "Debe inidicar por quien fue referido el paciente";
                else
                    mensaje = "Debe inidicar la razón por la que fue referido el paciente";

            return mensaje;
        }

        private void llenaDatos()
        {
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Clear();
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_Referido.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(RTB_RazonReferencia.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_NombrePediatra.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_TelefonoPediatra.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_NombreNeuroPediatra.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_TelefonoNeuroPediatra.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_M.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_Cm.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_Kg.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(TB_G.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(RTB_Terapias.Text.ToString());
            Utilitaria.Utilitaria.listaReferenciaEntrevista.Add(RTB_Medicamentos.Text.ToString());
        }

        private void cargaDatos()
        {
            try
            {
                TB_Referido.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[0];
                RTB_RazonReferencia.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[1];
                TB_NombrePediatra.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[2];
                TB_TelefonoPediatra.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[3];
                TB_NombreNeuroPediatra.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[4];
                TB_TelefonoNeuroPediatra.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[5];
                TB_M.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[6];
                TB_Cm.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[7];
                TB_Kg.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[8];
                TB_G.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[9];
                RTB_Terapias.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[10];
                RTB_Medicamentos.Text = Utilitaria.Utilitaria.listaReferenciaEntrevista[11];
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
            }
        }

        private void TB_Referido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_NombrePediatra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_NombreNeuroPediatra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_Kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_G_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_Cm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoPediatra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoNeuroPediatra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void RTB_RazonReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*'
                && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RTB_Terapias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*'
                && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RTB_Medicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*'
                && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
