using System;
using System.Collections.Generic;
using System.Text;

namespace classAnimal23._03
{
    class Animal
    {
        private string nome;

        public Animal(string nome)
        {
            this.nome = nome;
        }

        public class NewAnimal
        {
            NewAnimal newClass = new NewAnimal();
        }


        public void Acordar()
        {
            Console.WriteLine("O animal acordou");
        }
        public void Comer()
        {
            Console.WriteLine("O animal comeu");
        }
        public void Dormir()
        {
            Console.WriteLine("O animal dormiu");
        }
    }
}
