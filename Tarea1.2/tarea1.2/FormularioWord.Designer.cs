namespace tarea1._2
{
    partial class FormularioWord
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
            this.rtbTextoWord1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearWord = new System.Windows.Forms.Button();
            this.rtbTextoWord2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbTextoWord1
            // 
            this.rtbTextoWord1.Location = new System.Drawing.Point(52, 78);
            this.rtbTextoWord1.Name = "rtbTextoWord1";
            this.rtbTextoWord1.Size = new System.Drawing.Size(288, 96);
            this.rtbTextoWord1.TabIndex = 3;
            this.rtbTextoWord1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto Word";
            // 
            // btnCrearWord
            // 
            this.btnCrearWord.Location = new System.Drawing.Point(52, 300);
            this.btnCrearWord.Name = "btnCrearWord";
            this.btnCrearWord.Size = new System.Drawing.Size(145, 23);
            this.btnCrearWord.TabIndex = 5;
            this.btnCrearWord.Text = "Crear Word";
            this.btnCrearWord.UseVisualStyleBackColor = true;
            this.btnCrearWord.Click += new System.EventHandler(this.BtnCrearWord_Click);
            // 
            // rtbTextoWord2
            // 
            this.rtbTextoWord2.Location = new System.Drawing.Point(52, 189);
            this.rtbTextoWord2.Name = "rtbTextoWord2";
            this.rtbTextoWord2.Size = new System.Drawing.Size(288, 96);
            this.rtbTextoWord2.TabIndex = 6;
            this.rtbTextoWord2.Text = "";
            // 
            // FormularioWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 401);
            this.Controls.Add(this.rtbTextoWord2);
            this.Controls.Add(this.btnCrearWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbTextoWord1);
            this.Name = "FormularioWord";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbTextoWord1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearWord;
        private System.Windows.Forms.RichTextBox rtbTextoWord2;
    }
}

