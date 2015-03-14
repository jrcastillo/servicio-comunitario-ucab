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

namespace SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia
{
    public partial class Hitos : Form
    {
        public Hitos()
        {
            InitializeComponent();
            cargaHitos();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación, de ser así, no se guardaran los datos y volvera al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SGA_ConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Anterior_Click(object sender, EventArgs e)
        {
            llenaDatosHitos();
            EntrevistaFisioTerapia.ReferenciaEntrevista nuevaVentana = new EntrevistaFisioTerapia.ReferenciaEntrevista();
            nuevaVentana.Show();
            this.Close();
        }

        private void B_Siguiente_Click(object sender, EventArgs e)
        {
            llenaDatosHitos();
            //EntrevistaFisioTerapia.Actividades nuevaVentana = new EntrevistaFisioTerapia.Actividades();
            //nuevaVentana.Show();
            this.Close();      
        }

        private void llenaDatosHitos()
        {
            Utilitaria.Utilitaria.listahitos.Clear();
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoCC.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesCC.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoRolando.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesRolando.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoVoltearse.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesVoltearse.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoSentarse.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesSentarse.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoSentarseDesdeAcostado.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesSentarseDesdeAcostado.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoGatear.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesGatear.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoBipedo.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesBipedo.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoMarcha.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesMarcha.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoEscalon.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesEscalon.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_AñoCaja.Text.ToString());
            Utilitaria.Utilitaria.listahitos.Add(TB_MesCaja.Text.ToString());
        }

        private void cargaHitos()
        {
            try
            {
                TB_AñoCC.Text = Utilitaria.Utilitaria.listahitos[0];
                TB_MesCC.Text = Utilitaria.Utilitaria.listahitos[1];
                TB_AñoRolando.Text = Utilitaria.Utilitaria.listahitos[2];
                TB_MesRolando.Text = Utilitaria.Utilitaria.listahitos[3];
                TB_AñoVoltearse.Text = Utilitaria.Utilitaria.listahitos[4];
                TB_MesVoltearse.Text = Utilitaria.Utilitaria.listahitos[5];
                TB_AñoSentarse.Text = Utilitaria.Utilitaria.listahitos[6];
                TB_MesSentarse.Text = Utilitaria.Utilitaria.listahitos[7];
                TB_AñoSentarseDesdeAcostado.Text = Utilitaria.Utilitaria.listahitos[8];
                TB_MesSentarseDesdeAcostado.Text = Utilitaria.Utilitaria.listahitos[9];
                TB_AñoGatear.Text = Utilitaria.Utilitaria.listahitos[10];
                TB_MesGatear.Text = Utilitaria.Utilitaria.listahitos[11];
                TB_AñoBipedo.Text = Utilitaria.Utilitaria.listahitos[12];
                TB_MesBipedo.Text = Utilitaria.Utilitaria.listahitos[13];
                TB_AñoMarcha.Text = Utilitaria.Utilitaria.listahitos[14];
                TB_MesMarcha.Text = Utilitaria.Utilitaria.listahitos[15];
                TB_AñoEscalon.Text = Utilitaria.Utilitaria.listahitos[16];
                TB_MesEscalon.Text = Utilitaria.Utilitaria.listahitos[17];
                TB_AñoCaja.Text = Utilitaria.Utilitaria.listahitos[18];
                TB_MesCaja.Text = Utilitaria.Utilitaria.listahitos[19];
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
            }
        }

        private void TB_AñoCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoRolando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesRolando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoVoltearse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesVoltearse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoSentarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesSentarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoSentarseDesdeAcostado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesSentarseDesdeAcostado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoGatear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesGatear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoBipedo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesBipedo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoMarcha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesMarcha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoEscalon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesEscalon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_AñoCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_MesCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


   
        
    }
}
