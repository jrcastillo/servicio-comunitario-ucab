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
    public partial class AgregarProductoInventario : Form
    {
        public AgregarProductoInventario()
        {
            InitializeComponent();
            llenarComboBoxProductos();
        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            bool datos = validarCampos();
            if (!datos)
            {
                string mensaje = verificacionCamposVacios();
                MessageBox.Show(mensaje,"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                guardarEnInventario(Convert.ToInt32(TB_Cantidad.Text.ToString()));       
        }

        private void TB_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar y volver a la ventana principal de inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private bool validarCampos()
        {
            if (CB_Productos.SelectedIndex == -1 || TB_Cantidad.Text == "")
                return false;
            else
                return true;
        }

        private string verificacionCamposVacios() 
        {
            string mensaje = "";
            if (CB_Productos.SelectedIndex == -1)
            {
                if (TB_Cantidad.Text == "")
                    mensaje = "Debe elegir un producto e indicar la cantidad de dicho producto que desea agregar al inventario";
                    
                else
                    mensaje = "Debe elegir el producto que desea agregar al inventario";
            }
            else
                mensaje = "Debe indicar la cantidad del producto elegido que desea agregar al inventario";

            return mensaje;
        }

        private void llenarComboBoxProductos() 
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosProductos = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaProductosInventario, Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosProductos.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos

                for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
                {
                    CB_Productos.Items.Add(datosObtenidos.Tables[0].Rows[i][0].ToString());
                }

                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception ex)
            {
                string excepcion = ex.ToString();
                MessageBox.Show("En este momento no hay productos registrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CB_Productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void guardarEnInventario(int cantidad) 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand GuardarProducto = conexion.CreateCommand();
                GuardarProducto.CommandText = Utilitaria.Utilitaria.modificarProductoInventario(cantidad, idProducto());
                GuardarProducto.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Producto agregado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
                MessageBox.Show("No se pudo agregar el producto al inventario, vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int idProducto() 
        {
            int identificador = 0;
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosProductos = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaIdProducto(CB_Productos.SelectedItem.ToString()), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosProductos.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
           
                identificador = Convert.ToInt32(datosObtenidos.Tables[0].Rows[0][0].ToString());     
  
            Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión

            return identificador;
        }

        private void LL_AgregarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar un producto a la lista del inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.AgregarProductoLista nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.AgregarProductoLista();
                nuevaVentana.Show();
                this.Close();
            }
        }


    }
}
