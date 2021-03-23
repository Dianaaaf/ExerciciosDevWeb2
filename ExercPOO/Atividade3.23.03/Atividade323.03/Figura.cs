using System;

namespace Atividade323._03
{
    class Program
    {
        abstract class Figura 
        {
            private double x;

            public Figura()
            {
                x = 10;
            }

            abstract public double CalcularArea();
            abstract public double CalcularPerimetro();


            // Equilatero, Quadrado, Circulo, Pentagono, Hexagono
            public class Equilatero{ }
            public class Quadrado { }
            public class Circulo { }
            public class Pentagono { }
            public class Hexagono { }

            interface Controle
            {
                public void Desenhar() { }
            }
            interface Superficie
            {
                public void Pintar() { }
            }

        }
    }
}
