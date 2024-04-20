using System;
namespace util
{
	public abstract class Forma : IForma
	{
		protected double lado, raio, Base, altura;
		protected const double pi = 3.14159;

		public abstract double CalcularArea();
		public abstract double CalcularPerimetro();
		public virtual void Mostrar() => Console.WriteLine($"Perímetro: {CalcularPerimetro()}\nÁrea: {CalcularArea()}");
	}
}