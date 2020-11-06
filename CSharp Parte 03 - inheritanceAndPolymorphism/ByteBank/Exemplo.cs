using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class Exemplo : Casa, Carro
    {     
        public override void AbrirPorta()
        {
            int five = 5;
        }
    }

    public abstract class Casa
    {
        public abstract void AbrirPorta();
    }

    interface Carro
    {
        public abstract void AbrirPorta();
    }
}