namespace SGA_ConsultorioMedicoChuao.Vista
{
    partial class ComposicionRegistroListaEspera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_DetallesReferencia = new System.Windows.Forms.RichTextBox();
            this.B_Guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.L_DetallesReferencia = new System.Windows.Forms.Label();
            this.L_NombreApellidoRepresentante = new System.Windows.Forms.Label();
            this.L_NombreApellidoPaciente = new System.Windows.Forms.Label();
            this.L_TelefonoContacto = new System.Windows.Forms.Label();
            this.L_TelefonoOpcional = new System.Windows.Forms.Label();
            this.TB_NombreApellidoPaciente = new System.Windows.Forms.TextBox();
            this.TB_NombreApellidoRepresentante = new System.Windows.Forms.TextBox();
            this.TB_TelefonoContacto = new System.Windows.Forms.TextBox();
            this.TB_ReferidoPor = new System.Windows.Forms.TextBox();
            this.TB_TelefonoOpcional = new System.Windows.Forms.TextBox();
            this.L_ReferidoPor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Composición de registro";
            // 
            // RTB_DetallesReferencia
            // 
            this.RTB_DetallesReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_DetallesReferencia.Location = new System.Drawing.Point(12, 319);
            this.RTB_DetallesReferencia.Name = "RTB_DetallesReferencia";
            this.RTB_DetallesReferencia.Size = new System.Drawing.Size(1159, 257);
            this.RTB_DetallesReferencia.TabIndex = 6;
            this.RTB_DetallesReferencia.Text = "";
            this.RTB_DetallesReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTB_DetallesReferencia_KeyPress);
            // 
            // B_Guardar
            // 
            this.B_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Guardar.FlatAppearance.BorderSize = 0;
            this.B_Guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Guardar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Guardar;
            this.B_Guardar.Location = new System.Drawing.Point(412, 582);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 67);
            this.B_Guardar.TabIndex = 7;
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 651);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "GUARDAR";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(695, 651);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 4;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(707, 582);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 66);
            this.B_Cancelar.TabIndex = 8;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // L_DetallesReferencia
            // 
            this.L_DetallesReferencia.AutoSize = true;
            this.L_DetallesReferencia.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DetallesReferencia.Location = new System.Drawing.Point(12, 294);
            this.L_DetallesReferencia.Name = "L_DetallesReferencia";
            this.L_DetallesReferencia.Size = new System.Drawing.Size(249, 18);
            this.L_DetallesReferencia.TabIndex = 6;
            this.L_DetallesReferencia.Text = "DETALLES DE LA REFERENCIA";
            // 
            // L_NombreApellidoRepresentante
            // 
            this.L_NombreApellidoRepresentante.AutoSize = true;
            this.L_NombreApellidoRepresentante.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreApellidoRepresentante.Location = new System.Drawing.Point(12, 123);
            this.L_NombreApellidoRepresentante.Name = "L_NombreApellidoRepresentante";
            this.L_NombreApellidoRepresentante.Size = new System.Drawing.Size(359, 18);
            this.L_NombreApellidoRepresentante.TabIndex = 7;
            this.L_NombreApellidoRepresentante.Text = "NOMBRE Y APELLIDO DEL REPRESENTANTE";
            // 
            // L_NombreApellidoPaciente
            // 
            this.L_NombreApellidoPaciente.AutoSize = true;
            this.L_NombreApellidoPaciente.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreApellidoPaciente.Location = new System.Drawing.Point(12, 64);
            this.L_NombreApellidoPaciente.Name = "L_NombreApellidoPaciente";
            this.L_NombreApellidoPaciente.Size = new System.Drawing.Size(303, 18);
            this.L_NombreApellidoPaciente.TabIndex = 8;
            this.L_NombreApellidoPaciente.Text = "NOMBRE Y APELLIDO DEL PACIENTE";
            // 
            // L_TelefonoContacto
            // 
            this.L_TelefonoContacto.AutoSize = true;
            this.L_TelefonoContacto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TelefonoContacto.Location = new System.Drawing.Point(12, 179);
            this.L_TelefonoContacto.Name = "L_TelefonoContacto";
            this.L_TelefonoContacto.Size = new System.Drawing.Size(220, 18);
            this.L_TelefonoContacto.TabIndex = 9;
            this.L_TelefonoContacto.Text = "TELEFONO DE CONTACTO";
            // 
            // L_TelefonoOpcional
            // 
            this.L_TelefonoOpcional.AutoSize = true;
            this.L_TelefonoOpcional.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TelefonoOpcional.Location = new System.Drawing.Point(292, 179);
            this.L_TelefonoOpcional.Name = "L_TelefonoOpcional";
            this.L_TelefonoOpcional.Size = new System.Drawing.Size(187, 18);
            this.L_TelefonoOpcional.TabIndex = 10;
            this.L_TelefonoOpcional.Text = "TELEFONO OPCIONAL";
            // 
            // TB_NombreApellidoPaciente
            // 
            this.TB_NombreApellidoPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NombreApellidoPaciente.Location = new System.Drawing.Point(15, 90);
            this.TB_NombreApellidoPaciente.Name = "TB_NombreApellidoPaciente";
            this.TB_NombreApellidoPaciente.Size = new System.Drawing.Size(1156, 26);
            this.TB_NombreApellidoPaciente.TabIndex = 1;
            this.TB_NombreApellidoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NombreApellidoPaciente_KeyPress);
            // 
            // TB_NombreApellidoRepresentante
            // 
            this.TB_NombreApellidoRepresentante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NombreApellidoRepresentante.Location = new System.Drawing.Point(15, 148);
            this.TB_NombreApellidoRepresentante.Name = "TB_NombreApellidoRepresentante";
            this.TB_NombreApellidoRepresentante.Size = new System.Drawing.Size(1156, 26);
            this.TB_NombreApellidoRepresentante.TabIndex = 2;
            this.TB_NombreApellidoRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NombreApellidoRepresentante_KeyPress);
            // 
            // TB_TelefonoContacto
            // 
            this.TB_TelefonoContacto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TelefonoContacto.Location = new System.Drawing.Point(15, 204);
            this.TB_TelefonoContacto.Name = "TB_TelefonoContacto";
            this.TB_TelefonoContacto.Size = new System.Drawing.Size(246, 26);
            this.TB_TelefonoContacto.TabIndex = 3;
            this.TB_TelefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TelefonoContacto_KeyPress);
            // 
            // TB_ReferidoPor
            // 
            this.TB_ReferidoPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ReferidoPor.Location = new System.Drawing.Point(15, 261);
            this.TB_ReferidoPor.Name = "TB_ReferidoPor";
            this.TB_ReferidoPor.Size = new System.Drawing.Size(1156, 26);
            this.TB_ReferidoPor.TabIndex = 5;
            this.TB_ReferidoPor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ReferidoPor_KeyPress);
            // 
            // TB_TelefonoOpcional
            // 
            this.TB_TelefonoOpcional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TelefonoOpcional.Location = new System.Drawing.Point(295, 204);
            this.TB_TelefonoOpcional.Name = "TB_TelefonoOpcional";
            this.TB_TelefonoOpcional.Size = new System.Drawing.Size(246, 26);
            this.TB_TelefonoOpcional.TabIndex = 4;
            this.TB_TelefonoOpcional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TelefonoOpcional_KeyPress);
            // 
            // L_ReferidoPor
            // 
            this.L_ReferidoPor.AutoSize = true;
            this.L_ReferidoPor.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ReferidoPor.Location = new System.Drawing.Point(12, 237);
            this.L_ReferidoPor.Name = "L_ReferidoPor";
            this.L_ReferidoPor.Size = new System.Drawing.Size(128, 18);
            this.L_ReferidoPor.TabIndex = 15;
            this.L_ReferidoPor.Text = "REFERIDO POR";
            // 
            // ComposicionRegistroListaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1186, 681);
            this.ControlBox = false;
            this.Controls.Add(this.TB_TelefonoOpcional);
            this.Controls.Add(this.L_ReferidoPor);
            this.Controls.Add(this.TB_ReferidoPor);
            this.Controls.Add(this.TB_TelefonoContacto);
            this.Controls.Add(this.TB_NombreApellidoRepresentante);
            this.Controls.Add(this.TB_NombreApellidoPaciente);
            this.Controls.Add(this.L_TelefonoOpcional);
            this.Controls.Add(this.L_TelefonoContacto);
            this.Controls.Add(this.L_NombreApellidoPaciente);
            this.Controls.Add(this.L_NombreApellidoRepresentante);
            this.Controls.Add(this.L_DetallesReferencia);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Guardar);
            this.Controls.Add(this.RTB_DetallesReferencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComposicionRegistroListaEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComposicionRegistroListaEspera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_DetallesReferencia;
        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_DetallesReferencia;
        private System.Windows.Forms.Label L_NombreApellidoRepresentante;
        private System.Windows.Forms.Label L_NombreApellidoPaciente;
        private System.Windows.Forms.Label L_TelefonoContacto;
        private System.Windows.Forms.Label L_TelefonoOpcional;
        private System.Windows.Forms.TextBox TB_NombreApellidoPaciente;
        private System.Windows.Forms.TextBox TB_NombreApellidoRepresentante;
        private System.Windows.Forms.TextBox TB_TelefonoContacto;
        private System.Windows.Forms.TextBox TB_ReferidoPor;
        private System.Windows.Forms.TextBox TB_TelefonoOpcional;
        private System.Windows.Forms.Label L_ReferidoPor;
    }
}