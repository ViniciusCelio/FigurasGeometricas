using System;
namespace util
{
	public abstract class Forma : IForma
	{
		protected double lado, raio, Base, altura;
		protected const double pi = 3.14159;
		public abstract double CalcularArea();
		public abstract double CalcularPerimetro();
        public virtual (string resultadoStr, string imgNome) Mostrar()
		{
			return ($"Per�metro: {Math.Round(CalcularPerimetro(), 2)}\n�rea: {Math.Round(CalcularArea(), 2)}", "");
		}
	}
}