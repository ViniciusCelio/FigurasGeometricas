using System;
using util;
namespace formas
{
    public class Circulo : Forma
    {
        public Circulo(double _raio) => this.raio = _raio;

        public override double CalcularPerimetro() => 2 * pi * raio;

        public override double CalcularArea() => pi * (raio * raio);

        public override string Mostrar()
        {
            return $"Círculo:\n" + base.Mostrar();
        }
    }
}