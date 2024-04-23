namespace FigurasGeometricas
{
    partial class ResultadoCirculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoCirculo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelResultadoCirculo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Resultados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelResultadoCirculo
            // 
            labelResultadoCirculo.AutoSize = true;
            labelResultadoCirculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultadoCirculo.Location = new Point(277, 43);
            labelResultadoCirculo.Name = "labelResultadoCirculo";
            labelResultadoCirculo.Size = new Size(22, 21);
            labelResultadoCirculo.TabIndex = 3;
            labelResultadoCirculo.Text = "...";
            // 
            // ResultadoCirculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 290);
            Controls.Add(labelResultadoCirculo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ResultadoCirculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado forma: Círculo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label labelResultadoCirculo;
    }
}