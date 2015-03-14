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

namespace SGA_ConsultorioMedicoChuao.Vista
{
    public partial class ReduccionProductoInventario : Form
    {
        public ReduccionProductoInventario()
        {
            InitializeComponent();
            L_ProductoActual.Text = "Producto: " + Utilitaria.Utilitaria.nombreProductoSeleccionado;
            L_CantidadActual.Text = "La cantidad actual es: " + Utilitaria.Utilitaria.cantidadProductoInventario.ToString();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver a la ventana de gestion de eliminación de productos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.Vista.TipoEliminacionProducto nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.TipoEliminacionProducto();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private bool validarCampoVacio() 
        {
            bool lleno = false;

            if (TB_Cantidad.Text != "")
                lleno = true;

            return lleno;
        }

        private void TB_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            bool lleno = validarCampoVacio();

            if (!lleno)
                MessageBox.Show("No indico la cantidad de este producto que desea quitar del invventario, por lo cual no se puede realizar la operación seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Utilitaria.Utilitaria.cantidadProductoInventario < Convert.ToInt32(TB_Cantidad.Text))
                    MessageBox.Show("Indico una cantidad mayor a la que se tiene, por lo cual no se puede realizar la operación seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    reducirCantidad();
            }
        }

        private void reducirCantidad() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand GuardarProducto = conexion.CreateCommand();
                GuardarProducto.CommandText = Utilitaria.Utilitaria.disminuirProductoInventario(Convert.ToInt32(TB_Cantidad.Text.ToString()), Utilitaria.Utilitaria.identificadorProductoInventario);
                GuardarProducto.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Cantidad del producto disminuida con exito en el inventario", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
                MessageBox.Show("No se pudo disminuir la cantidad del producto en el inventario, vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
