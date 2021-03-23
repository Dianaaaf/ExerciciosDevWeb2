using System;
using System.Collections.Generic;
using System.Text;

namespace classAnimal23._03
{
    class Baleia:Mamifero
    {
        private string tipoBaleia;
        private string tipoMamifero;
        private string nome;

        public Baleia(string tipoBaleia, string tipoMamifero, string nome):base(tipoMamifero, nome)
        {
            this.tipoBaleia = tipoBaleia;
            this.tipoMamifero = tipoMamifero;
            this.nome = nome;
        }

        public class NewBaleia
        {
            NewBaleia newBaleia = new NewBaleia();
        }

        public void Nadar() { }
    }
}
