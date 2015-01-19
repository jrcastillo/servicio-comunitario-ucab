using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    public partial class PrincipalInventario : Form
    {
        public PrincipalInventario()
        {
            InitializeComponent();
            cargarInventario();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir y volver al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Quitar_Click(object sender, EventArgs e)
        {

        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar producto(s) al inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.AgregarProductoInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.AgregarProductoInventario();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void cargarInventario()
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosInventario = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaInventario, Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosInventario.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
                for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)     
                    LB_Inventario.Items.Add(datosObtenidos.Tables[0].Rows[i][0].ToString()); // Mostrar los datos en el lb
                
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
                MessageBox.Show("No tiene productos registrados en el inventario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
