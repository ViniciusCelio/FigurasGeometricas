using System;
using util;
namespace formas
{
    public class Triangulo : Forma
    {
        private double ladoA, ladoB, ladoC;
        public Triangulo(double _ladoA, double _ladoB, double _ladoC)
        {
            this.ladoA = _ladoA;
            this.ladoB = _ladoB;
            this.ladoC = _ladoC;
        }

        public override double CalcularPerimetro() => ladoA + ladoB + ladoC;

        public override double CalcularArea()
        {
            double s = CalcularPerimetro() / 2;
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
        }

        public override void Mostrar()
        {
            Console.WriteLine("<<<< Triângulo >>>>");
            base.Mostrar();
        }
    }
}