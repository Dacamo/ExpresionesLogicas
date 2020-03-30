namespace ExpresionesLogicasUI
{
    partial class formCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCalculadora = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBorrarDeAUno = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnImplicacion = new System.Windows.Forms.Button();
            this.btnOperadorO = new System.Windows.Forms.Button();
            this.btnOperadorY = new System.Windows.Forms.Button();
            this.BtnParentesisCierra = new System.Windows.Forms.Button();
            this.BtnParentesisAbre = new System.Windows.Forms.Button();
            this.btnSiYSoloSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CALCULADORA";
            // 
            // textBoxCalculadora
            // 
            this.textBoxCalculadora.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCalculadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCalculadora.Location = new System.Drawing.Point(39, 32);
            this.textBoxCalculadora.Name = "textBoxCalculadora";
            this.textBoxCalculadora.ReadOnly = true;
            this.textBoxCalculadora.Size = new System.Drawing.Size(379, 20);
            this.textBoxCalculadora.TabIndex = 11;
            this.textBoxCalculadora.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(51, 68);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 30);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "AC";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrarDeAUno
            // 
            this.btnBorrarDeAUno.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrarDeAUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarDeAUno.ForeColor = System.Drawing.Color.Red;
            this.btnBorrarDeAUno.Location = new System.Drawing.Point(172, 68);
            this.btnBorrarDeAUno.Name = "btnBorrarDeAUno";
            this.btnBorrarDeAUno.Size = new System.Drawing.Size(95, 30);
            this.btnBorrarDeAUno.TabIndex = 18;
            this.btnBorrarDeAUno.Text = "ADEL";
            this.btnBorrarDeAUno.UseVisualStyleBackColor = false;
            this.btnBorrarDeAUno.Click += new System.EventHandler(this.btnBorrarDeAUno_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIgual.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnIgual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIgual.Location = new System.Drawing.Point(303, 68);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(100, 30);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnP.Location = new System.Drawing.Point(65, 107);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(58, 37);
            this.btnP.TabIndex = 20;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQ.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnQ.Location = new System.Drawing.Point(194, 107);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(58, 37);
            this.btnQ.TabIndex = 21;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Gainsboro;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnR.Location = new System.Drawing.Point(323, 107);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(58, 37);
            this.btnR.TabIndex = 22;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnImplicacion
            // 
            this.btnImplicacion.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnImplicacion.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnImplicacion.Location = new System.Drawing.Point(323, 169);
            this.btnImplicacion.Name = "btnImplicacion";
            this.btnImplicacion.Size = new System.Drawing.Size(58, 37);
            this.btnImplicacion.TabIndex = 26;
            this.btnImplicacion.Text = "→";
            this.btnImplicacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImplicacion.UseVisualStyleBackColor = false;
            this.btnImplicacion.Click += new System.EventHandler(this.btnImplicacion_Click);
            // 
            // btnOperadorO
            // 
            this.btnOperadorO.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOperadorO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperadorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOperadorO.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnOperadorO.Location = new System.Drawing.Point(194, 169);
            this.btnOperadorO.Name = "btnOperadorO";
            this.btnOperadorO.Size = new System.Drawing.Size(58, 37);
            this.btnOperadorO.TabIndex = 25;
            this.btnOperadorO.Text = "V";
            this.btnOperadorO.UseVisualStyleBackColor = false;
            this.btnOperadorO.Click += new System.EventHandler(this.btnOperadorO_Click);
            // 
            // btnOperadorY
            // 
            this.btnOperadorY.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOperadorY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperadorY.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnOperadorY.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnOperadorY.Location = new System.Drawing.Point(65, 169);
            this.btnOperadorY.Name = "btnOperadorY";
            this.btnOperadorY.Size = new System.Drawing.Size(58, 37);
            this.btnOperadorY.TabIndex = 24;
            this.btnOperadorY.Text = "^";
            this.btnOperadorY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOperadorY.UseVisualStyleBackColor = false;
            this.btnOperadorY.Click += new System.EventHandler(this.btnOperadorY_Click);
            // 
            // BtnParentesisCierra
            // 
            this.BtnParentesisCierra.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnParentesisCierra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParentesisCierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnParentesisCierra.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BtnParentesisCierra.Location = new System.Drawing.Point(323, 229);
            this.BtnParentesisCierra.Name = "BtnParentesisCierra";
            this.BtnParentesisCierra.Size = new System.Drawing.Size(58, 37);
            this.BtnParentesisCierra.TabIndex = 30;
            this.BtnParentesisCierra.Text = ")";
            this.BtnParentesisCierra.UseVisualStyleBackColor = false;
            this.BtnParentesisCierra.Click += new System.EventHandler(this.BtnParentesisCierra_Click);
            // 
            // BtnParentesisAbre
            // 
            this.BtnParentesisAbre.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnParentesisAbre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParentesisAbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnParentesisAbre.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BtnParentesisAbre.Location = new System.Drawing.Point(194, 229);
            this.BtnParentesisAbre.Name = "BtnParentesisAbre";
            this.BtnParentesisAbre.Size = new System.Drawing.Size(58, 37);
            this.BtnParentesisAbre.TabIndex = 29;
            this.BtnParentesisAbre.Text = "(";
            this.BtnParentesisAbre.UseVisualStyleBackColor = false;
            this.BtnParentesisAbre.Click += new System.EventHandler(this.BtnParentesisAbre_Click);
            // 
            // btnSiYSoloSi
            // 
            this.btnSiYSoloSi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSiYSoloSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiYSoloSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSiYSoloSi.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnSiYSoloSi.Location = new System.Drawing.Point(65, 229);
            this.btnSiYSoloSi.Name = "btnSiYSoloSi";
            this.btnSiYSoloSi.Size = new System.Drawing.Size(58, 37);
            this.btnSiYSoloSi.TabIndex = 28;
            this.btnSiYSoloSi.Text = "↔";
            this.btnSiYSoloSi.UseVisualStyleBackColor = false;
            this.btnSiYSoloSi.Click += new System.EventHandler(this.btnSiYSoloSi_Click);
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(439, 315);
            this.Controls.Add(this.BtnParentesisCierra);
            this.Controls.Add(this.BtnParentesisAbre);
            this.Controls.Add(this.btnSiYSoloSi);
            this.Controls.Add(this.btnImplicacion);
            this.Controls.Add(this.btnOperadorO);
            this.Controls.Add(this.btnOperadorY);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnBorrarDeAUno);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCalculadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCalculadora;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrarDeAUno;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnImplicacion;
        private System.Windows.Forms.Button btnOperadorO;
        private System.Windows.Forms.Button btnOperadorY;
        private System.Windows.Forms.Button BtnParentesisCierra;
        private System.Windows.Forms.Button BtnParentesisAbre;
        private System.Windows.Forms.Button btnSiYSoloSi;
    }
}

