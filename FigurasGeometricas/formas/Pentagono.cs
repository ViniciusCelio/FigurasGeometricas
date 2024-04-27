using System;
using util;
namespace formas
{
    public class Pentagono : Forma
    {
        public Pentagono(double _lado) => this.lado = _lado;


        public override double CalcularPerimetro() => lado * 5;
        public override double CalcularArea() => (lado * lado) * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4;
        public override (string resultadoStr, string imgNome) Mostrar()
        {
            return ($"Pentágono:\n" + base.Mostrar().resultadoStr, "pentagono");
        }
    }
}