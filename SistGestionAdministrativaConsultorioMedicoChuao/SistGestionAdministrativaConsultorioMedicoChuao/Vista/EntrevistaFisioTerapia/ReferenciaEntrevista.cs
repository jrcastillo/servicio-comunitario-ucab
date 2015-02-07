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
            SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.Hitos();
            nuevaVentana.Show();
            this.Close();
        }

        private void B_Anterior_Click(object sender, EventArgs e)
        {
            SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.DatosPersonalesFisio nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.DatosPersonalesFisio();
            nuevaVentana.Show();
            this.Close();
        }

   
        
    }
}
