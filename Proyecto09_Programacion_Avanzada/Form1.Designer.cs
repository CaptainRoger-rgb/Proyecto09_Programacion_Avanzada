namespace Proyecto09_Programacion_Avanzada
{
    partial class Form1
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimTem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConetion = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.Green;
            this.btnConectar.Location = new System.Drawing.Point(39, 227);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(168, 37);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "C O N E C T A R";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.Color.Red;
            this.btnDesconectar.Location = new System.Drawing.Point(270, 227);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(189, 37);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "D E S C O N E C T A R";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Límite de Temperatura:";
            // 
            // txtLimTem
            // 
            this.txtLimTem.Location = new System.Drawing.Point(39, 76);
            this.txtLimTem.Name = "txtLimTem";
            this.txtLimTem.Size = new System.Drawing.Size(100, 20);
            this.txtLimTem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura:";
            // 
            // lblConetion
            // 
            this.lblConetion.AutoSize = true;
            this.lblConetion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConetion.ForeColor = System.Drawing.Color.Aqua;
            this.lblConetion.Location = new System.Drawing.Point(36, 148);
            this.lblConetion.Name = "lblConetion";
            this.lblConetion.Size = new System.Drawing.Size(144, 24);
            this.lblConetion.TabIndex = 5;
            this.lblConetion.Text = "Sin Conexion";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.Orange;
            this.lblTemperatura.Location = new System.Drawing.Point(268, 164);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(55, 34);
            this.lblTemperatura.TabIndex = 6;
            this.lblTemperatura.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblConetion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLimTem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLimTem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConetion;
        private System.Windows.Forms.Label lblTemperatura;
    }
}

