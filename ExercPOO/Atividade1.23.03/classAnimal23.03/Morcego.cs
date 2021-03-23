using System;
using System.Collections.Generic;
using System.Text;

namespace classAnimal23._03
{
    class Morcego:Mamifero
    {
        private string tipoMamifero;
        private string tipoAnimal;
        private string nome;

        public Morcego(string tipoMamifero, string tipoAnimal, string nome):base(tipoAnimal, nome)
        {
            this.tipoMamifero = tipoMamifero;
            this.tipoAnimal = tipoAnimal;
            this.nome = nome;
        }

        public class NewMorcego
        {
            NewMorcego newMorcego = new NewMorcego();
        }

        public void Voar() { }
    }
}
