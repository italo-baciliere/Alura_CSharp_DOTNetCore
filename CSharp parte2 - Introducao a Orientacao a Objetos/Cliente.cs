using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_parte2___Introducao_a_Orientacao_a_Objetos
{
    public class Cliente
    /*
-   É fácil definir o que é um "Cliente" porque estamos no domínio do ByteBank,
- no qual o cliente do banco vai à agência, possui uma conta-corrente, faz saques, entres outros.
-
-   Porém, além do domínio do ByteBank, o termo "Cliente" pode ter outros significados. Em um
- salão de beleza, por exemplo, tem um significado diferente do que tem no banco. A preocupação
- com os dados é diferente nesses ambientes. No salão, ser mais interessante guardar dados como cor
- do cabelo ou tipo de unhas; em vez das informações que são importantes para o ByteBank, como
- CPF e profissão. Nesses dois casos, sabemos que "Cliente" se refere a pessoas.
-
-   Como diremos ao C# que estamos falando do cliente do ByteBank, e não da topologia de rede,
- do que pode conflitar com uma classe qualquer do dotNET ou do dotNET Framework. A solução
- para esse problema é a utilização de namespace, que o Visual Studio fornece no código, por padrão.
*/
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
    }
}
