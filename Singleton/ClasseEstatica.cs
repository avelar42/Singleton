using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    static public class ClasseEstatica
    {

        private static readonly int variavelEstatica;
        static ClasseEstatica()
        {
            variavelEstatica = 1;
        }
        public static string ExibirValor()
        {
            return string.Format("O Valor da variavel estatica e {0}", variavelEstatica);
        }
        public static string Mensagem { get; set; }
    }
}
