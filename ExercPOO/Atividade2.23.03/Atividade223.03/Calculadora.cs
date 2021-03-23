using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade223._03
{
    class Calculadora
    {
        public int soma;
        public int subtracao;
        public int multiplicacao;
        public int divisao;

        public int x = 5;
        public int y = 5;

        public Calculadora(int soma, int subtracao, int multiplicacao, int divisao, int x)
        {
            this.soma = soma;
            this.subtracao = subtracao;
            this.multiplicacao = multiplicacao;
            this.divisao = divisao;
            this.x = x;
        }

        public void Soma()
        {
            soma = x + y;
            Console.WriteLine("O resultado da soma é: " + soma);
        }
        public void Subtração()
        {
            subtracao = x - y;
            Console.WriteLine("O resultado da subtração é: " + subtracao);
        }
        public void Multiplicação()
        {
            multiplicacao = x * y;
            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
        }
        public void Divisão()
        {
            divisao = x / y;
            Console.WriteLine("O resultado da divisão é: " + divisao);
        }

    }
}
