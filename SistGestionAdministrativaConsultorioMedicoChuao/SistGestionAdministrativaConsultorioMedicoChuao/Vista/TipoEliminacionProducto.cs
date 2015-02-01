using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    public partial class TipoEliminacionProducto : Form
    {
        public TipoEliminacionProducto()
        {
            InitializeComponent();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver a la ventana principal del inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
        }
    }
}
