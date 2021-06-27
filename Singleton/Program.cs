using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patters *SINGLETON*");

            //CLASSE NORMAL USO E INSTANCIACAO
            var classeNormal = new ClasseNormal { VariavelNormal = 26 };
            Console.WriteLine("Uso da classe normal: " + classeNormal.VariavelNormal);

            //CLASSE ESTATICA
            string valorRetornado = ClasseEstatica.ExibirValor();
            Console.WriteLine("Uso da classe estatica: " + valorRetornado);

            //CLASSE SINGLETON
            var variavelSingleton = ClasseSingleton.Instancia;
            variavelSingleton.Mensagem = "TESTE SINGLETON";
            Console.WriteLine("Uso da classe singleton: " + variavelSingleton.Mensagem);

            //TESTE PARA VER SE OUTRAS CLASSES SINGLETONS SAO IGUAIS
            var outraVariavelSingleton = ClasseSingleton.Instancia;
            Console.WriteLine("Verificando Instancias sao as mesmas : " + variavelSingleton.Equals(outraVariavelSingleton));
            Console.Read();


        }
    }
}
