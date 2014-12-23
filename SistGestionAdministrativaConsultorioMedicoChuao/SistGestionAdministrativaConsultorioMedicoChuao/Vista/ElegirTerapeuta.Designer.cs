namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class ElegirTerapeuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.L_ElegirTerapeuta = new System.Windows.Forms.Label();
            this.DGV_ElegirTerapeuta = new System.Windows.Forms.DataGridView();
            this.DatosTerapeuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElegirTerapeuta)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(224, 340);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 3;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // L_ElegirTerapeuta
            // 
            this.L_ElegirTerapeuta.AutoSize = true;
            this.L_ElegirTerapeuta.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ElegirTerapeuta.Location = new System.Drawing.Point(152, 5);
            this.L_ElegirTerapeuta.Name = "L_ElegirTerapeuta";
            this.L_ElegirTerapeuta.Size = new System.Drawing.Size(265, 36);
            this.L_ElegirTerapeuta.TabIndex = 4;
            this.L_ElegirTerapeuta.Text = "Elegir Terapeuta";
            // 
            // DGV_ElegirTerapeuta
            // 
            this.DGV_ElegirTerapeuta.AllowUserToAddRows = false;
            this.DGV_ElegirTerapeuta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_ElegirTerapeuta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_ElegirTerapeuta.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DGV_ElegirTerapeuta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_ElegirTerapeuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ElegirTerapeuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosTerapeuta,
            this.Elegir,
            this.identificador});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ElegirTerapeuta.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_ElegirTerapeuta.GridColor = System.Drawing.SystemColors.Desktop;
            this.DGV_ElegirTerapeuta.Location = new System.Drawing.Point(12, 48);
            this.DGV_ElegirTerapeuta.Name = "DGV_ElegirTerapeuta";
            this.DGV_ElegirTerapeuta.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_ElegirTerapeuta.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_ElegirTerapeuta.Size = new System.Drawing.Size(526, 214);
            this.DGV_ElegirTerapeuta.TabIndex = 5;
            this.DGV_ElegirTerapeuta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ElegirTerapeuta_CellContentClick);
            // 
            // DatosTerapeuta
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosTerapeuta.DefaultCellStyle = dataGridViewCellStyle10;
            this.DatosTerapeuta.FillWeight = 150F;
            this.DatosTerapeuta.HeaderText = "Datos terapeuta";
            this.DatosTerapeuta.MinimumWidth = 8;
            this.DatosTerapeuta.Name = "DatosTerapeuta";
            this.DatosTerapeuta.ReadOnly = true;
            this.DatosTerapeuta.Width = 382;
            // 
            // Elegir
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Elegir.DefaultCellStyle = dataGridViewCellStyle11;
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            this.Elegir.Text = "Elegir";
            this.Elegir.ToolTipText = "Elegir";
            // 
            // identificador
            // 
            this.identificador.HeaderText = "identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Visible = false;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(230, 278);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(89, 59);
            this.B_Cancelar.TabIndex = 1;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // ElegirTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(550, 367);
            this.ControlBox = false;
            this.Controls.Add(this.DGV_ElegirTerapeuta);
            this.Controls.Add(this.L_ElegirTerapeuta);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.B_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirTerapeuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElegirTerapeuta";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElegirTerapeuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Label L_ElegirTerapeuta;
        private System.Windows.Forms.DataGridView DGV_ElegirTerapeuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosTerapeuta;
        private System.Windows.Forms.DataGridViewButtonColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
    }
}