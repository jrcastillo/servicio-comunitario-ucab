namespace SGA_ConsultorioMedicoChuao.Vista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.L_ElegirTerapeuta.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ElegirTerapeuta.Location = new System.Drawing.Point(152, 5);
            this.L_ElegirTerapeuta.Name = "L_ElegirTerapeuta";
            this.L_ElegirTerapeuta.Size = new System.Drawing.Size(274, 40);
            this.L_ElegirTerapeuta.TabIndex = 4;
            this.L_ElegirTerapeuta.Text = "Elegir Terapeuta";
            // 
            // DGV_ElegirTerapeuta
            // 
            this.DGV_ElegirTerapeuta.AllowUserToAddRows = false;
            this.DGV_ElegirTerapeuta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_ElegirTerapeuta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ElegirTerapeuta.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ElegirTerapeuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ElegirTerapeuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosTerapeuta,
            this.Elegir,
            this.identificador});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ElegirTerapeuta.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_ElegirTerapeuta.GridColor = System.Drawing.SystemColors.Desktop;
            this.DGV_ElegirTerapeuta.Location = new System.Drawing.Point(12, 48);
            this.DGV_ElegirTerapeuta.Name = "DGV_ElegirTerapeuta";
            this.DGV_ElegirTerapeuta.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_ElegirTerapeuta.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_ElegirTerapeuta.Size = new System.Drawing.Size(526, 214);
            this.DGV_ElegirTerapeuta.TabIndex = 5;
            this.DGV_ElegirTerapeuta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ElegirTerapeuta_CellContentClick);
            // 
            // DatosTerapeuta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosTerapeuta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatosTerapeuta.FillWeight = 150F;
            this.DatosTerapeuta.HeaderText = "Datos terapeuta";
            this.DatosTerapeuta.MinimumWidth = 8;
            this.DatosTerapeuta.Name = "DatosTerapeuta";
            this.DatosTerapeuta.ReadOnly = true;
            this.DatosTerapeuta.Width = 382;
            // 
            // Elegir
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Elegir.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.B_Cancelar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
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