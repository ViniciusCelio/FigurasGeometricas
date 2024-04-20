using System;
using util;
namespace formas
{
    public class Hexagono : Forma
    {
        public Hexagono(double _lado) => this.lado = _lado;

        public override double CalcularPerimetro() => 6 * lado;

        public override double CalcularArea() => (3 * (lado * lado) * Math.Sqrt(3)) / 2;

        public override void Mostrar()
        {
            Console.WriteLine("<<<< Hexágono >>>>");
            base.Mostrar();
        }
    }
}