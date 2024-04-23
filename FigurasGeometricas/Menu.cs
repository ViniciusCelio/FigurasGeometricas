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
                var calcularQuadrado = new ResultadoQuadrado(objQuadrado);
                calcularQuadrado.Show();
                inputQuadrado.Text = "";
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputQuadrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnOctogonoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objOctogono = new Octogono(double.Parse(inputOctogono.Text));
                var calcularOctagono = new ResultadoOctagono(objOctogono);
                calcularOctagono.Show();
                inputOctogono.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputOctogono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnPentaganoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objPentagono = new Pentagono(double.Parse(inputPentagono.Text));
                var calcularPentagono = new ResultadoPentagono(objPentagono);
                calcularPentagono.Show();
                inputPentagono.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputPentagono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnRetanguloMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objRetangulo = new Retangulo(double.Parse(inputRetanguloBase.Text),
                                                 double.Parse(inputRetanguloAltura.Text));
                var calcularRetangulo = new ResultadoRetangulo(objRetangulo);
                calcularRetangulo.Show();
                inputRetanguloAltura.Text = string.Empty;
                inputRetanguloBase.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputRetanguloBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void inputRetanguloAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnTrianguloMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objTriangulo = new Triangulo(double.Parse(inputTriangulo1.Text),
                                                 double.Parse(inputTriangulo2.Text),
                                                 double.Parse(inputTriangulo3.Text));
                var calcularTriangulo = new ResultadoTriangulo(objTriangulo);
                calcularTriangulo.Show();
                inputTriangulo1.Text = string.Empty;
                inputTriangulo2.Text = string.Empty;
                inputTriangulo3.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputTriangulo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void inputTriangulo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void inputTriangulo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnCirculoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objCirculo = new Circulo(double.Parse(inputCirculo.Text));
                var calcularCirculo = new ResultadoCirculo(objCirculo);
                calcularCirculo.Show();
                inputCirculo.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputCirculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnHexagonoMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var objHexagono = new Hexagono(double.Parse(inputHexagono.Text));
                var calcularHexagono = new ResultadoHexagono(objHexagono);
                calcularHexagono.Show();
                inputHexagono.Text = string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }
        private void inputHexagono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}