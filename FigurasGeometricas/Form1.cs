using formas;
using System.Linq.Expressions;

namespace FigurasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Oct�gono escolhido! ");
                var calcularOctagono = new AreaCalcular();
                calcularOctagono.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Pent�gono escolhido! ");
                var calcularPentagono = new AreaCalcular();
                calcularPentagono.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ret�ngulo escolhido! ");
                var calcularRetangulo = new AreaCalcular();
                calcularRetangulo.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Tri�ngulo escolhido! ");
                var calcularTriangulo = new AreaCalcular();
                calcularTriangulo.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("C�rculo escolhido! ");
                var calcularRaio = new AreaCalcular();
                calcularRaio.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("erro!!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Hex�gono escolhido! ");
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