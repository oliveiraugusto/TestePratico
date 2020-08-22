namespace TestePratico
{
    partial class FormPrincipal
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
            this.textBoxDistanciaTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDistanciaEntrePilares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDistanciaBaseReforcada = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDistanciaTotal
            // 
            this.textBoxDistanciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistanciaTotal.Location = new System.Drawing.Point(27, 78);
            this.textBoxDistanciaTotal.MaxLength = 12;
            this.textBoxDistanciaTotal.Name = "textBoxDistanciaTotal";
            this.textBoxDistanciaTotal.Size = new System.Drawing.Size(105, 26);
            this.textBoxDistanciaTotal.TabIndex = 0;
            this.textBoxDistanciaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiametroTotal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distancia total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distancia minima entre pilares";
            // 
            // textBoxDistanciaEntrePilares
            // 
            this.textBoxDistanciaEntrePilares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistanciaEntrePilares.Location = new System.Drawing.Point(27, 139);
            this.textBoxDistanciaEntrePilares.MaxLength = 12;
            this.textBoxDistanciaEntrePilares.Name = "textBoxDistanciaEntrePilares";
            this.textBoxDistanciaEntrePilares.Size = new System.Drawing.Size(216, 26);
            this.textBoxDistanciaEntrePilares.TabIndex = 1;
            this.textBoxDistanciaEntrePilares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDistanciaEntrePilares_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distancia maxima para base reforçada";
            // 
            // textBoxDistanciaBaseReforcada
            // 
            this.textBoxDistanciaBaseReforcada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistanciaBaseReforcada.Location = new System.Drawing.Point(27, 206);
            this.textBoxDistanciaBaseReforcada.MaxLength = 12;
            this.textBoxDistanciaBaseReforcada.Name = "textBoxDistanciaBaseReforcada";
            this.textBoxDistanciaBaseReforcada.Size = new System.Drawing.Size(281, 26);
            this.textBoxDistanciaBaseReforcada.TabIndex = 2;
            this.textBoxDistanciaBaseReforcada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDistanciaBaseReforcada_KeyPress);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(111, 251);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(116, 46);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(23, 346);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 24);
            this.labelResultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "10 ULTIMOS REGISTROS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(187, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "TODOS DOS REGISTROS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(345, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDistanciaBaseReforcada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDistanciaEntrePilares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDistanciaTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Inicio | Teste Pratico C#";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDistanciaTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDistanciaEntrePilares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDistanciaBaseReforcada;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

