using System;
using util;
namespace formas
{
    public class Octogono : Forma
    {
        public Octogono(double _lado) => this.lado = _lado;

        public override double CalcularPerimetro() => 8 * lado;

        public override double CalcularArea() => 2 * (1 + Math.Sqrt(2)) * (lado * lado);

        public override void Mostrar()
        {
            Console.WriteLine("<<<< Octógono >>>>");
            base.Mostrar();
        }
    }
}