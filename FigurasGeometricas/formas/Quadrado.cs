using System;
using util;
namespace formas
{
    public class Quadrado : Forma
    {
        public Quadrado(double _lado) => this.lado = _lado;

        public override double CalcularPerimetro() => 4 * lado;

        public override double CalcularArea() => lado * lado;

        public override void Mostrar()
        {
            Console.WriteLine("<<<< Quadrado >>>>");
            base.Mostrar();
        }
    }
}