namespace Sistema_de_R.Humanos
{
    partial class Nuevo_expediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_expediente));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionaPdf = new System.Windows.Forms.Button();
            this.pdfResultado = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo expediente";
            // 
            // btnSeleccionaPdf
            // 
            this.btnSeleccionaPdf.Location = new System.Drawing.Point(393, 92);
            this.btnSeleccionaPdf.Name = "btnSeleccionaPdf";
            this.btnSeleccionaPdf.Size = new System.Drawing.Size(106, 23);
            this.btnSeleccionaPdf.TabIndex = 1;
            this.btnSeleccionaPdf.Text = "Selecciona PDF";
            this.btnSeleccionaPdf.UseVisualStyleBackColor = true;
            this.btnSeleccionaPdf.Click += new System.EventHandler(this.btnSeleccionaPdf_Click);
            // 
            // pdfResultado
            // 
            this.pdfResultado.Enabled = true;
            this.pdfResultado.Location = new System.Drawing.Point(156, 153);
            this.pdfResultado.Name = "pdfResultado";
            this.pdfResultado.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfResultado.OcxState")));
            this.pdfResultado.Size = new System.Drawing.Size(606, 346);
            this.pdfResultado.TabIndex = 2;
            // 
            // Nuevo_expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 524);
            this.Controls.Add(this.pdfResultado);
            this.Controls.Add(this.btnSeleccionaPdf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nuevo_expediente";
            this.Text = "Nuevo_expediente";
            ((System.ComponentModel.ISupportInitialize)(this.pdfResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionaPdf;
        private AxAcroPDFLib.AxAcroPDF pdfResultado;
    }
}