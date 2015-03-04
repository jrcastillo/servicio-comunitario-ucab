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
    public partial class ModificarProductoInventario : Form
    {
        public ModificarProductoInventario()
        {
            InitializeComponent();
            TB_Producto.Text = Utilitaria.Utilitaria.nombreProductoSeleccionado;
            TB_Cantidad.Text = Utilitaria.Utilitaria.cantidadProductoInventario.ToString();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir y volver a la ventana principal del inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            bool valido = validarCampos();

            if (valido)
                modificarProducto();
            else
            { 
                string mensaje = mensajeValidacion();
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modificarProducto()
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand ModificarMensaje = conexion.CreateCommand();
                ModificarMensaje.CommandText = Utilitaria.Utilitaria.modificarProductoInventario(TB_Producto.Text, Convert.ToInt32(TB_Cantidad.Text.ToString()), Utilitaria.Utilitaria.identificadorProductoInventario);
                ModificarMensaje.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Producto modificado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string excepcion = exp.ToString();
                MessageBox.Show("El producto no pudo ser modificado, intente luego", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validarCampos() 
        {
            bool validos = false;

            if (!TB_Producto.Text.Equals("") && TB_Cantidad.Text != "")
                validos = true;

            return validos;
        }

        private string mensajeValidacion() 
        {
            string mensaje = "";

            if (TB_Producto.Text.Equals("") && TB_Cantidad.Text == "")
                mensaje = "Ni el nombre del producto ni la cantidad pueden estar vacios";
            else
            {
                if (TB_Producto.Text.Equals(""))
                    mensaje = "El nombre del producto no puede estar vacio";
                else
                    mensaje = "La cantidad del producto no puede estar vacia";
            }

            return mensaje;
        }

        private void TB_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.'
                && e.KeyChar != ',' && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

    }
}
