using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistGestionAdministrativaConsultorioMedicoChuao
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            Utilitaria.Utilitaria.reiniciarIdentificadorOpcion();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir del sistema?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            Application.Exit();
        }

        private void B_Mensajes_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(5);
            SistGestionAdministrativaConsultorioMedicoChuao.Vista.ElegirTerapeuta nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_ListaEspera_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(3);
        }

        private void B_BuscarPaciente_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(2);
        }

        private void B_Pagos_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(6);
        }

    }
}
