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
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos();
                nuevaVentana.Show();
                this.Close();
            }
            else
                MessageBox.Show(mensajeError(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void B_Anterior_Click(object sender, EventArgs e)
        {
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
        
    }
}
