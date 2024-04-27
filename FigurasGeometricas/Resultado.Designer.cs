namespace FigurasGeometricas
{
    partial class Resultado
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
            label1 = new Label();
            labelResultado = new Label();
            imgBoxResultado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgBoxResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Resultados";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultado.Location = new Point(303, 56);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 21);
            labelResultado.TabIndex = 5;
            // 
            // imgBoxResultado
            // 
            imgBoxResultado.Location = new Point(24, 43);
            imgBoxResultado.Name = "imgBoxResultado";
            imgBoxResultado.Size = new Size(237, 220);
            imgBoxResultado.TabIndex = 6;
            imgBoxResultado.TabStop = false;
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 275);
            Controls.Add(imgBoxResultado);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Name = "Resultado";
            Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)imgBoxResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelResultado;
        private PictureBox imgBoxResultado;
    }
}