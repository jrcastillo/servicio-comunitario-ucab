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
    public partial class PrincipalHorarios : Form
    {
		public PrincipalHorarios()
        {
            InitializeComponent();
			GV_VistaHorarios.Visible = false;
			LlenarComboTerapeutas();
        }

		private void LlenarComboTerapeutas()
		{
			try
			{
				Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
				DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
				NpgsqlDataAdapter datosTerapeutas = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaTerapeutas, Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
				datosTerapeutas.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
				for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
				{
					CB_Terapeutas.DataSource = datosObtenidos.Tables[0];
					CB_Terapeutas.DisplayMember = "Persona";
					CB_Terapeutas.ValueMember = "Identificador";
				}
				Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
			}
			catch (Exception e)
			{
				string excepcion = e.ToString();
				MessageBox.Show("Se ha producido un error, intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void B_Agregar_Click(object sender, EventArgs e)
		{
			string fecha = MC_Calendario.SelectionStart.Date.ToShortDateString();
		}
 
    }
}
