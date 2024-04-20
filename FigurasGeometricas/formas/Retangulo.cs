using System;
using util;
namespace formas
{
    public class Retangulo : Forma
    {
        public Retangulo(double _base, double _altura)
        {
            this.Base = _base;
            this.altura = _altura;
        }

        public override double CalcularPerimetro() => 2 * (Base + altura);

        public override double CalcularArea() => Base * altura;

        public override void Mostrar()
        {
            Console.WriteLine("<<<< Retângulo >>>>");
            base.Mostrar();
        }
    }
}