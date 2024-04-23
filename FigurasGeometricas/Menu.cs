using formas;
using System.Linq.Expressions;
using util;

namespace FigurasGeometricas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnQuadradoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objQuadrado = new Quadrado(double.Parse(inputQuadrado.Text));
                var calcularQuadrado = new Resultado(objQuadrado);
                calcularQuadrado.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }

        }

        private void BtnOctogonoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objOctogono = new Octogono(double.Parse(inputOctogono.Text));
                var calcularOctagono = new Resultado(objOctogono);
                calcularOctagono.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void BtnPentaganoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objPentagono = new Pentagono(double.Parse(inputPentagono.Text));
                var calcularPentagono = new Resultado(objPentagono);
                calcularPentagono.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void BtnRetanguloMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objRetangulo = new Retangulo(double.Parse(inputRetanguloBase.Text), 
                                                 double.Parse(inputRetanguloAltura.Text));
                var calcularRetangulo = new Resultado(objRetangulo);
                calcularRetangulo.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }

        }

        private void BtnTrianguloMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objTriangulo = new Triangulo(double.Parse(inputTriangulo1.Text),
                                                 double.Parse(inputTriangulo2.Text),
                                                 double.Parse(inputTriangulo3.Text));
                var calcularTriangulo = new Resultado(objTriangulo);
                calcularTriangulo.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void BtnCirculoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objCirculo = new Circulo(double.Parse(inputCirculo.Text));
                var calcularCirculo = new Resultado(objCirculo);
                calcularCirculo.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void BtnHexagonoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objHexagono = new Hexagono(double.Parse(inputHexagono.Text));
                var calcularHexagono = new Resultado(objHexagono);
                calcularHexagono.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
    }
}