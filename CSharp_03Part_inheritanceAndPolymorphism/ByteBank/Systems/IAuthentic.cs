using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Employees;

namespace ByteBank.Systems
{        
    public interface IAuthentic               
    /*
     * Interface para funcionários que serão validados no sistema
     * 
     * Interface é um contrato onde quem assina se responsabiliza por
     *  implementar esses métodos (Comprir o contrato)
     * 
     * Todos que implementam essa interface devem criar o seu próprio método Authentic
     *
     * Interface nos garante a existência de um método Authenticate(),
     *  de retorno bool e string senha como argumento.
     *  
     * Todos os membros são públicos em interfaces.        
     * 
     * Para saber mais sobre Interface, visite o site: https://www.devmedia.com.br/interfaces-x-classes-abstratas/13337  
     */
    {
        bool Authentic(string senha);
    }
}
