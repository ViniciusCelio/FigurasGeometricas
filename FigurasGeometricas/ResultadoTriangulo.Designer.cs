namespace FigurasGeometricas
{
    partial class ResultadoTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoTriangulo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelResultadoTriangulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Resultados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelResultadoTriangulo
            // 
            labelResultadoTriangulo.AutoSize = true;
            labelResultadoTriangulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultadoTriangulo.Location = new Point(265, 42);
            labelResultadoTriangulo.Name = "labelResultadoTriangulo";
            labelResultadoTriangulo.Size = new Size(22, 21);
            labelResultadoTriangulo.TabIndex = 3;
            labelResultadoTriangulo.Text = "...";
            // 
            // ResultadoTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 290);
            Controls.Add(labelResultadoTriangulo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ResultadoTriangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultadoTriangulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label labelResultadoTriangulo;
    }
}