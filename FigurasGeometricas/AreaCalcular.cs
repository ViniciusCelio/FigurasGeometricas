using FigurasGeometricas;
using formas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util;

namespace FigurasGeometricas
{
    public partial class AreaCalcular : Form
    {
        public AreaCalcular()
        {
            InitializeComponent();
            CalcularArea();
        }
        public double CalcularArea()
        {
            double lado = double.Parse(textBox1.Text);
            return lado;
        }

        public double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public void Mostrar()
        {
            throw new NotImplementedException();
        }
    }
}