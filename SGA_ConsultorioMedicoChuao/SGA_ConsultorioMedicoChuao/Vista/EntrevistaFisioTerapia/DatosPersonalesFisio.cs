﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia
{
    public partial class DatosPersonalesFisio : Form
    {
        public DatosPersonalesFisio()
        {
            InitializeComponent();
            setearDatesPickers();
            cargaDatosMama();
            cargaDatosPapa();
            cargaDatosPaciente();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación, de ser así, no se guardaran los datos y volvera al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SGA_ConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void setearDatesPickers()
        {
            DTP_FechaNacMama.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacMama.MaxDate = DateTime.Today;
            DTP_FechaNacPapa.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacPapa.MaxDate = DateTime.Today;
            DTP_FechaNacPaciente.Text = DateTime.Today.ToShortDateString();
            DTP_FechaNacPaciente.MaxDate = DateTime.Today;
        }

        private bool validadCamposObligados() 
        {
            bool validos = false;
            
            if (DTP_FechaNacPaciente.Value.ToShortDateString() != DateTime.Today.ToShortDateString() && !TB_NombrePaciente.Text.Equals("")
                && !TB_ApellidoPaciente.Text.Equals("") && !TB_NombreMama.Text.Equals("") && !TB_ApellidoPapa.Text.Equals("") &&
                !TB_NombrePapa.Text.Equals("") && !TB_ApellidoPapa.Text.Equals("") && (RB_Masculino.Checked || RB_Femenino.Checked))
                    validos = true;

            return validos;

        }

        private void RTB_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*'
                && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_NombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_NombreMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_NombrePapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_ApellidoPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_CorreoMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '@' 
                && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_CedulaMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_CedulaPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCasaMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCelularMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCasaPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoCelularPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_CorreoElectronicoPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '@'
                && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void B_Siguiente_Click(object sender, EventArgs e)
        {
            bool camposObligadosLlenos = validadCamposObligados();

            if (camposObligadosLlenos)
            {
                llenaDatosMama();
                llenaDatosPapa();
                llenaDatosPaciente();
                SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.ReferenciaEntrevista nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.EntrevistaFisioTerapia.ReferenciaEntrevista();
                nuevaVentana.Show();
                this.Close();
            }
            else
                mensajesDeValidacion();
            
        }

        private void mensajesDeValidacion() 
        { 
            //if ( !
              //  && !TB_ApellidoPaciente.Text.Equals("") && !TB_NombreMama.Text.Equals("") && !TB_ApellidoPapa.Text.Equals("") &&
                //!TB_NombrePapa.Text.Equals("") && !TB_ApellidoPapa.Text.Equals("") && (RB_Masculino.Checked || RB_Femenino.Checked))
            
            if (DTP_FechaNacPaciente.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                MessageBox.Show("Debe asignar la fecha de nacimiento del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_NombrePaciente.Text.Equals(""))
                MessageBox.Show("Debe colocar el nombre del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_ApellidoPaciente.Text.Equals(""))
                MessageBox.Show("Debe colocar el apellido del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_NombreMama.Text.Equals(""))
                MessageBox.Show("Debe colocar el nombre de la madre del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_ApellidoMama.Text.Equals(""))
                MessageBox.Show("Debe colocar el apellido de la madre del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_NombrePapa.Text.Equals(""))
                MessageBox.Show("Debe colocar el nombre del padre del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TB_ApellidoPapa.Text.Equals(""))
                MessageBox.Show("Debe colocar el apellido del padre del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!RB_Masculino.Checked && !RB_Femenino.Checked)
                MessageBox.Show("Debe elegir el sexo del paciente para poder continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void llenaDatosMama() 
        {
            Utilitaria.Utilitaria.listaDatosMama.Clear();
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_NombreMama.Text.ToString());
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_ApellidoMama.Text.ToString());
            Utilitaria.Utilitaria.listaDatosMama.Add(DTP_FechaNacMama.Value.ToShortDateString());
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_CedulaMama.Text.ToString());
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_TelefonoCasaMama.Text.ToString());
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_TelefonoCelularMama.Text.ToString());
            Utilitaria.Utilitaria.listaDatosMama.Add(TB_CorreoMama.Text.ToString());
        }

        private void cargaDatosMama()
        {
            try
            {
                TB_NombreMama.Text = Utilitaria.Utilitaria.listaDatosMama[0];
                TB_ApellidoMama.Text = Utilitaria.Utilitaria.listaDatosMama[1];
                DTP_FechaNacMama.Value = Convert.ToDateTime(Utilitaria.Utilitaria.listaDatosMama[2]);
                TB_CedulaMama.Text = Utilitaria.Utilitaria.listaDatosMama[3];
                TB_TelefonoCasaMama.Text = Utilitaria.Utilitaria.listaDatosMama[4];
                TB_TelefonoCelularMama.Text = Utilitaria.Utilitaria.listaDatosMama[5];
                TB_CorreoMama.Text = Utilitaria.Utilitaria.listaDatosMama[6];
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
            }
        }

        private void llenaDatosPapa()
        {
            Utilitaria.Utilitaria.listaDatosPapa.Clear();
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_NombrePapa.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_ApellidoPapa.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(DTP_FechaNacPapa.Value.ToShortDateString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_CedulaPapa.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_TelefonoCasaPapa.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_TelefonoCelularPapa.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPapa.Add(TB_CorreoElectronicoPapa.Text.ToString());
        }

        private void cargaDatosPapa()
        {
            try
            {
                TB_NombrePapa.Text = Utilitaria.Utilitaria.listaDatosPapa[0];
                TB_ApellidoPapa.Text = Utilitaria.Utilitaria.listaDatosPapa[1];
                DTP_FechaNacPapa.Value = Convert.ToDateTime(Utilitaria.Utilitaria.listaDatosPapa[2]);
                TB_CedulaPapa.Text = Utilitaria.Utilitaria.listaDatosPapa[3];
                TB_TelefonoCasaPapa.Text = Utilitaria.Utilitaria.listaDatosPapa[4];
                TB_TelefonoCelularPapa.Text = Utilitaria.Utilitaria.listaDatosPapa[5];
                TB_CorreoElectronicoPapa.Text = Utilitaria.Utilitaria.listaDatosPapa[6];
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
            }
        }

        private void llenaDatosPaciente()
        {
            Utilitaria.Utilitaria.listaDatosPacienteFisio.Clear();
            Utilitaria.Utilitaria.listaDatosPacienteFisio.Add(TB_NombrePaciente.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPacienteFisio.Add(TB_ApellidoPaciente.Text.ToString());
            Utilitaria.Utilitaria.listaDatosPacienteFisio.Add(DTP_FechaNacPaciente.Value.ToShortDateString());
            if (RB_Femenino.Checked)
                Utilitaria.Utilitaria.listaDatosPacienteFisio.Add("Femenino");
            else
                Utilitaria.Utilitaria.listaDatosPacienteFisio.Add("Masculino");
            Utilitaria.Utilitaria.listaDatosPacienteFisio.Add(RTB_Direccion.Text.ToString());
        }

        private void cargaDatosPaciente()
        {
            try
            {
                TB_NombrePaciente.Text = Utilitaria.Utilitaria.listaDatosPacienteFisio[0];
                TB_ApellidoPaciente.Text = Utilitaria.Utilitaria.listaDatosPacienteFisio[1];
                DTP_FechaNacPaciente.Value = Convert.ToDateTime(Utilitaria.Utilitaria.listaDatosPacienteFisio[2]);
                if (Utilitaria.Utilitaria.listaDatosPacienteFisio[3].Equals("Femenino"))
                    RB_Femenino.Checked = true;
                else
                    RB_Masculino.Checked = true;
                RTB_Direccion.Text = Utilitaria.Utilitaria.listaDatosPacienteFisio[4];
                
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
            }
        }

        
    }
}
