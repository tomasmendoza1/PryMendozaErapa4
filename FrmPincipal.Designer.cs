namespace PryMendozaErapa4
{
    partial class FrmPincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstListadoDeVehiculos = new System.Windows.Forms.ListBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.BtnAvion = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstListadoDeVehiculos
            // 
            this.LstListadoDeVehiculos.FormattingEnabled = true;
            this.LstListadoDeVehiculos.Location = new System.Drawing.Point(414, 12);
            this.LstListadoDeVehiculos.Name = "LstListadoDeVehiculos";
            this.LstListadoDeVehiculos.Size = new System.Drawing.Size(120, 134);
            this.LstListadoDeVehiculos.TabIndex = 0;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(6, 152);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(122, 23);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Generar Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.Location = new System.Drawing.Point(262, 152);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(122, 23);
            this.btnBarco.TabIndex = 2;
            this.btnBarco.Text = "Generar Barco";
            this.btnBarco.UseVisualStyleBackColor = true;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // BtnAvion
            // 
            this.BtnAvion.Location = new System.Drawing.Point(134, 152);
            this.BtnAvion.Name = "BtnAvion";
            this.BtnAvion.Size = new System.Drawing.Size(122, 23);
            this.BtnAvion.TabIndex = 3;
            this.BtnAvion.Text = "Generar Avión";
            this.BtnAvion.UseVisualStyleBackColor = true;
            this.BtnAvion.Click += new System.EventHandler(this.BtnAvion_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(414, 152);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(120, 23);
            this.BtnListar.TabIndex = 4;
            this.BtnListar.Text = "Listado";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // FrmPincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(546, 188);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnAvion);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.LstListadoDeVehiculos);
            this.Name = "FrmPincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 4 - CREAR OBJETOS EN LISTA";
            this.Load += new System.EventHandler(this.FrmPincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstListadoDeVehiculos;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button BtnAvion;
        private System.Windows.Forms.Button BtnListar;
    }
}

