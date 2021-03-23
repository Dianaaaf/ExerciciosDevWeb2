using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade223._03
{
    class CalculadoraCientifica:Calculadora
    {
        public int raizQuadrada;

        public CalculadoraCientifica(int soma, int subtracao, int multiplicacao, int divisao, int x, int raizQuadrada):base(soma, subtracao, multiplicacao, divisao, x)
        {
            this.raizQuadrada = raizQuadrada;
            this.soma = soma;
            this.subtracao = subtracao;
            this.multiplicacao = multiplicacao;
            this.divisao = divisao;
            this.x = x;
        }

        public void RaizQuadrada()
        {
            int x = 5;
            Console.WriteLine("A raiz quadra é igual a: " + Math.Sqrt(x));
        }
    }
}
