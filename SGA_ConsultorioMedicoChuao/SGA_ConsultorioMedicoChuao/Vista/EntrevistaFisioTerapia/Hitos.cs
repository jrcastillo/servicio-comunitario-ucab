using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia
{
    public partial class Hitos : Form
    {
        public Hitos()
        {
            InitializeComponent();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación, de ser así, no se guardaran los datos y volvera al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SGA_ConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Anterior_Click(object sender, EventArgs e)
        {
            SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.ReferenciaEntrevista nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.ReferenciaEntrevista();
            nuevaVentana.Show();
            this.Close();
        }



   
        
    }
}
