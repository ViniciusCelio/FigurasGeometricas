﻿namespace FigurasGeometricas
{
    partial class ResultadoPentagono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoPentagono));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelResultadoPentagono = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Resultados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelResultadoPentagono
            // 
            labelResultadoPentagono.AutoSize = true;
            labelResultadoPentagono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultadoPentagono.Location = new Point(264, 49);
            labelResultadoPentagono.Name = "labelResultadoPentagono";
            labelResultadoPentagono.Size = new Size(22, 21);
            labelResultadoPentagono.TabIndex = 4;
            labelResultadoPentagono.Text = "...";
            // 
            // ResultadoPentagono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 290);
            Controls.Add(labelResultadoPentagono);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ResultadoPentagono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado forma : Pentágono";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label labelResultadoPentagono;
    }
}