using formas;
using System.Linq.Expressions;

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
                MessageBox.Show("Quadrado escolhido!");
                var calcularQuadrado = new AreaCalcular();
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
                MessageBox.Show("Octágono escolhido! ");
                var calcularOctagono = new AreaCalcular();
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
                MessageBox.Show("Pentágono escolhido! ");
                var calcularPentagono = new AreaCalcular();
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
                MessageBox.Show("Retângulo escolhido! ");
                var calcularRetangulo = new AreaCalcular();
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
                MessageBox.Show("Triângulo escolhido! ");
                var calcularTriangulo = new AreaCalcular();
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
                MessageBox.Show("Círculo escolhido! ");
                var calcularRaio = new AreaCalcular();
                calcularRaio.Show();
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
                MessageBox.Show("Hexágono escolhido! ");
                var calcularHexagono = new AreaCalcular();
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