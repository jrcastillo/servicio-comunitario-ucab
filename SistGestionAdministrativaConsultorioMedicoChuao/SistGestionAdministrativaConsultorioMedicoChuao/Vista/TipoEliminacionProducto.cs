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
    public partial class TipoEliminacionProducto : Form
    {
        public TipoEliminacionProducto()
        {
            InitializeComponent();
            L_Producto.Text = "Producto: " + Utilitaria.Utilitaria.nombreProductoSeleccionado;
            L_Cantidad.Text = "Cantidad = " + Utilitaria.Utilitaria.cantidadProductoInventario.ToString();
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

        private void B_Disminuir_Click(object sender, EventArgs e)
        {
            if (Utilitaria.Utilitaria.cantidadProductoInventario == 0)
                MessageBox.Show("La cantidad de este producto en el inventario no se puede reducir más ya que es igual a cero (0)", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea ir a la ventana de reducción de cantidad de producto en inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    SistGestionAdministrativaConsultorioMedicoChuao.Vista.ReduccionProductoInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.ReduccionProductoInventario();
                    nuevaVentana.Show();
                    this.Close();
                }
            }
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el producto del inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
                eliminarProducto();
            
        }

        private void eliminarProducto() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand BorrarRegistro = conexion.CreateCommand();
                BorrarRegistro.CommandText = Utilitaria.Utilitaria.borrarProducto(Utilitaria.Utilitaria.identificadorProductoInventario);
                BorrarRegistro.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Producto borrado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string exepcion = exp.ToString();
                MessageBox.Show("No se pudo borrar el producto, intentelo luego", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
