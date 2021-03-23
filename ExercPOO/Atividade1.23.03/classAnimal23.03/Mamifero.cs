using System;
using System.Collections.Generic;
using System.Text;

namespace classAnimal23._03
{
    class Mamifero:Animal
    {
        private string tipoAnimal;
        private string nome;

        public Mamifero(string tipoAnimal, string nome):base(nome)
        {
            this.tipoAnimal = tipoAnimal;
            this.nome = nome;
        }

        public class NewMamifero
        {
            NewMamifero newMamifero = new NewMamifero();
        }

        public void Mamar() { }
    }
}
