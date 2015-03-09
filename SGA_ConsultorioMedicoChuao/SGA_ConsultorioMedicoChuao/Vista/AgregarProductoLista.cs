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
    public partial class AgregarProductoLista : Form
    {
        public AgregarProductoLista()
        {
            InitializeComponent();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar y volver a la ventana de agregar producto al inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.Vista.AgregarProductoInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.AgregarProductoInventario();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void agregarALista() 
        { 
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand GuardarProducto = conexion.CreateCommand();
                GuardarProducto.CommandText = Utilitaria.Utilitaria.agregarProductoInventario(TB_Nombre.Text);
                GuardarProducto.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Producto agregado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalInventario();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
                MessageBox.Show("No se pudo agregar el producto a la lista, vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            }

        private bool validaCampo() 
        {
            bool valido = false;

            if (!TB_Nombre.Text.Equals(""))
                valido = true;

            return valido;
        }

        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.'
                && e.KeyChar != ',' && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            bool valido = validaCampo();
            bool validanombre = validaRepetidos();

            if (valido && validanombre)
                agregarALista();
            else
                MessageBox.Show("No se pudo agregar el producto a la lista, vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool validaRepetidos() 
        {
            bool valido = false;
        
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosInventario = new NpgsqlDataAdapter(Utilitaria.Utilitaria.validaExistenciaProducto(TB_Nombre.Text), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta       
                datosInventario.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos

                if (Convert.ToInt32(datosObtenidos.Tables[0].Rows[0][0].ToString()) == 0)
                    valido = true;
                else
                     MessageBox.Show("El producto ya pertenece a la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión      

            return valido;
        }
    }
}
