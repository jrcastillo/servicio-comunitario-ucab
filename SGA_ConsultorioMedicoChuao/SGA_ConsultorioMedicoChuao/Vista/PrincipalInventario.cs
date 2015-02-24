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
    public partial class PrincipalInventario : Form
    {
        List<string> nombreProductos = new List<string>();
        List<int> cantidadProductos = new List<int>();

        public PrincipalInventario()
        {
            InitializeComponent();
            Utilitaria.Utilitaria.reiniciarCantidadProductoInventario();
            Utilitaria.Utilitaria.reiniciarIdentificadorProductoInventario();
            Utilitaria.Utilitaria.reiniciarNombreProductoSeleccionado();
            cargarInventario();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir y volver al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SGA_ConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Quitar_Click(object sender, EventArgs e)
        {
            int seleccionado = LB_Inventario.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Primero debe seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea ir a la ventana de gestion de eliminación de productos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                        Utilitaria.Utilitaria.agregarValorIdentificadorProductoInventario(idProductoInventario());
                        Utilitaria.Utilitaria.agregarCantidadProductoInventario(cantidadProductos[LB_Inventario.SelectedIndex]);
                        Utilitaria.Utilitaria.agregarValorNombreProductoSeleccionado(nombreProductos[LB_Inventario.SelectedIndex]);
                    SGA_ConsultorioMedicoChuao.Vista.TipoEliminacionProducto nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.TipoEliminacionProducto();
                    nuevaVentana.Show();
                    this.Close();
                }
            }
        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar producto(s) al inventario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.Vista.AgregarProductoInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.AgregarProductoInventario();
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
                {
                    LB_Inventario.Items.Add("Productos: " + datosObtenidos.Tables[0].Rows[i][0].ToString() + ". Cantidad: " + datosObtenidos.Tables[0].Rows[i][1].ToString()); // Mostrar los datos en el lb
                    nombreProductos.Add(datosObtenidos.Tables[0].Rows[i][0].ToString());
                    cantidadProductos.Add(Convert.ToInt32(datosObtenidos.Tables[0].Rows[i][1].ToString()));                   
                }
                
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
                MessageBox.Show("No tiene productos registrados en el inventario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int idProductoInventario() 
        {
            Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
            DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
            NpgsqlDataAdapter datosListaEspera = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaIdProducto(nombreProductos[LB_Inventario.SelectedIndex]), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
            datosListaEspera.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
            Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            return Convert.ToInt32(datosObtenidos.Tables[0].Rows[0][0].ToString());
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            int seleccionado = LB_Inventario.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Primero debe seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea ir a la ventana de modificación del producto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                        Utilitaria.Utilitaria.agregarValorIdentificadorProductoInventario(idProductoInventario());
                        Utilitaria.Utilitaria.agregarCantidadProductoInventario(cantidadProductos[LB_Inventario.SelectedIndex]);
                        Utilitaria.Utilitaria.agregarValorNombreProductoSeleccionado(nombreProductos[LB_Inventario.SelectedIndex]);
                    SGA_ConsultorioMedicoChuao.Vista.ModificarProductoInventario nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.ModificarProductoInventario();
                    nuevaVentana.Show();
                    this.Close();
                }
            }
        }


    }
}
