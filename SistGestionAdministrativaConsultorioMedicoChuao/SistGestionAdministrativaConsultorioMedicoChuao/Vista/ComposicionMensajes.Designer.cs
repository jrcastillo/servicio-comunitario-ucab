namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class ComposicionMensajes
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
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.L_ComposicionMensaje = new System.Windows.Forms.Label();
            this.L_TituloMensaje = new System.Windows.Forms.Label();
            this.L_CuerpoMensaje = new System.Windows.Forms.Label();
            this.L_GuardarMensaje = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.TB_Titulo = new System.Windows.Forms.TextBox();
            this.RTB_CuerpoMensaje = new System.Windows.Forms.RichTextBox();
            this.B_GuardarMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(712, 589);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 58);
            this.B_Cancelar.TabIndex = 1;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // L_ComposicionMensaje
            // 
            this.L_ComposicionMensaje.AutoSize = true;
            this.L_ComposicionMensaje.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ComposicionMensaje.Location = new System.Drawing.Point(390, 9);
            this.L_ComposicionMensaje.Name = "L_ComposicionMensaje";
            this.L_ComposicionMensaje.Size = new System.Drawing.Size(385, 40);
            this.L_ComposicionMensaje.TabIndex = 2;
            this.L_ComposicionMensaje.Text = "Composición de mensaje";
            // 
            // L_TituloMensaje
            // 
            this.L_TituloMensaje.AutoSize = true;
            this.L_TituloMensaje.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TituloMensaje.Location = new System.Drawing.Point(8, 69);
            this.L_TituloMensaje.Name = "L_TituloMensaje";
            this.L_TituloMensaje.Size = new System.Drawing.Size(193, 20);
            this.L_TituloMensaje.TabIndex = 3;
            this.L_TituloMensaje.Text = "TÍTULO DEL MENSAJE";
            // 
            // L_CuerpoMensaje
            // 
            this.L_CuerpoMensaje.AutoSize = true;
            this.L_CuerpoMensaje.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CuerpoMensaje.Location = new System.Drawing.Point(8, 130);
            this.L_CuerpoMensaje.Name = "L_CuerpoMensaje";
            this.L_CuerpoMensaje.Size = new System.Drawing.Size(199, 20);
            this.L_CuerpoMensaje.TabIndex = 4;
            this.L_CuerpoMensaje.Text = "CUERPO DEL MENSAJE";
            // 
            // L_GuardarMensaje
            // 
            this.L_GuardarMensaje.AutoSize = true;
            this.L_GuardarMensaje.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_GuardarMensaje.Location = new System.Drawing.Point(349, 650);
            this.L_GuardarMensaje.Name = "L_GuardarMensaje";
            this.L_GuardarMensaje.Size = new System.Drawing.Size(170, 18);
            this.L_GuardarMensaje.TabIndex = 5;
            this.L_GuardarMensaje.Text = "GUARDAD MENSAJE";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(700, 650);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 6;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // TB_Titulo
            // 
            this.TB_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Titulo.Location = new System.Drawing.Point(12, 92);
            this.TB_Titulo.Name = "TB_Titulo";
            this.TB_Titulo.Size = new System.Drawing.Size(1118, 26);
            this.TB_Titulo.TabIndex = 7;
            this.TB_Titulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Titulo_KeyPress);
            // 
            // RTB_CuerpoMensaje
            // 
            this.RTB_CuerpoMensaje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_CuerpoMensaje.Location = new System.Drawing.Point(12, 153);
            this.RTB_CuerpoMensaje.Name = "RTB_CuerpoMensaje";
            this.RTB_CuerpoMensaje.Size = new System.Drawing.Size(1118, 421);
            this.RTB_CuerpoMensaje.TabIndex = 8;
            this.RTB_CuerpoMensaje.Text = "";
            this.RTB_CuerpoMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTB_CuerpoMensaje_KeyPress);
            // 
            // B_GuardarMensaje
            // 
            this.B_GuardarMensaje.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_GuardarMensaje.FlatAppearance.BorderSize = 0;
            this.B_GuardarMensaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_GuardarMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_GuardarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_GuardarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GuardarMensaje.ForeColor = System.Drawing.SystemColors.Control;
            this.B_GuardarMensaje.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Guardar;
            this.B_GuardarMensaje.Location = new System.Drawing.Point(396, 589);
            this.B_GuardarMensaje.Name = "B_GuardarMensaje";
            this.B_GuardarMensaje.Size = new System.Drawing.Size(75, 58);
            this.B_GuardarMensaje.TabIndex = 0;
            this.B_GuardarMensaje.UseVisualStyleBackColor = false;
            this.B_GuardarMensaje.Click += new System.EventHandler(this.B_GuardarMensaje_Click);
            // 
            // ComposicionMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1142, 680);
            this.ControlBox = false;
            this.Controls.Add(this.RTB_CuerpoMensaje);
            this.Controls.Add(this.TB_Titulo);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.L_GuardarMensaje);
            this.Controls.Add(this.L_CuerpoMensaje);
            this.Controls.Add(this.L_TituloMensaje);
            this.Controls.Add(this.L_ComposicionMensaje);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_GuardarMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComposicionMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComposicionMensajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_GuardarMensaje;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_ComposicionMensaje;
        private System.Windows.Forms.Label L_TituloMensaje;
        private System.Windows.Forms.Label L_CuerpoMensaje;
        private System.Windows.Forms.Label L_GuardarMensaje;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.TextBox TB_Titulo;
        private System.Windows.Forms.RichTextBox RTB_CuerpoMensaje;
    }
}