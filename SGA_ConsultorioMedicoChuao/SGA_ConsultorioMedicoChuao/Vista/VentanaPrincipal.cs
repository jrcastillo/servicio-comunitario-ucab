using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA_ConsultorioMedicoChuao.Vista;

namespace SGA_ConsultorioMedicoChuao
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            Utilitaria.Utilitaria.reiniciarIdentificadorOpcion();
            Utilitaria.Utilitaria.reiniciarIdentificadorTerapeuta();
            Utilitaria.Utilitaria.reiniciarIdentificadorMensaje();
            Utilitaria.Utilitaria.reiniciarIdentificadorRegistroListaEspera();
            Utilitaria.Utilitaria.reiniciarIdentificadorProductoInventario();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir del sistema?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            Application.Exit();
        }

        private void B_Mensajes_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(5);
            SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_ListaEspera_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(3);
            SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_BuscarPaciente_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(2);
            SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_Pagos_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(6);
            ElegirTerapeuta nuevaVentana = new ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_Inventario_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(7);
            PrincipalInventario nuevaVentana = new PrincipalInventario();
            nuevaVentana.Show();
            this.Hide();  
        }

        private void B_Inscripcion_Click(object sender, EventArgs e)
        {
            Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(1);
            ElegirTerapeuta nuevaVentana = new ElegirTerapeuta();
            nuevaVentana.Show();
            this.Hide(); 
        }

		private void B_Horarios_Click(object sender, EventArgs e)
		{
			Utilitaria.Utilitaria.ventanaPrincipal = this;
			Utilitaria.Utilitaria.agregarValorIdentificadorOpcion(8);
			PrincipalHorarios nuevaVentana = new PrincipalHorarios();
			nuevaVentana.Show();
			Utilitaria.Utilitaria.ventanaPrincipal.Hide();
		}

    }
}
