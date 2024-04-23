namespace FigurasGeometricas
{
    partial class ResultadoRetangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoRetangulo));
            label1 = new Label();
            labelResultadoRetangulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Resultados";
            // 
            // labelResultadoRetangulo
            // 
            labelResultadoRetangulo.AutoSize = true;
            labelResultadoRetangulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultadoRetangulo.Location = new Point(285, 47);
            labelResultadoRetangulo.Name = "labelResultadoRetangulo";
            labelResultadoRetangulo.Size = new Size(22, 21);
            labelResultadoRetangulo.TabIndex = 2;
            labelResultadoRetangulo.Text = "...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ResultadoRetangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 290);
            Controls.Add(pictureBox1);
            Controls.Add(labelResultadoRetangulo);
            Controls.Add(label1);
            Name = "ResultadoRetangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado foma :Retangulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelResultadoRetangulo;
        private PictureBox pictureBox1;
    }
}